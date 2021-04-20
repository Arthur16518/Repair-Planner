using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Data.Models
{
    public class GraphItem
    {
        public int worksNum { get; set; }

        public DateTime day { get; set; }

        public double heightPercent { get; set; }
    }

    public class Statistics
    {
        public int totalWorks { get; set; }

        public double average { get; set; }

        public int totalDays { get; set; }

        public List<GraphItem> graph { get; set; }

        public Statistics() { }

        public Statistics(IEnumerable<Stage> stagesFor30d)
        {
            graph = new List<GraphItem>();
            totalWorks = stagesFor30d.Count();
            foreach (var stage in stagesFor30d)
            {
                int graphI = SearchDayByNumber(stage.date);
                if (graphI == -1)
                {
                    graph.Add(new GraphItem { day = stage.date, worksNum = 1 });
                }
                else
                {
                    graph[graphI].worksNum++;
                }
            }

            int maxWorks = 0;
            for (int i = 0; i < graph.Count; i++)
                if (graph[i].worksNum > maxWorks)
                    maxWorks = graph[i].worksNum;

            foreach(var item in graph)
            {
                item.heightPercent = Math.Round((double)item.worksNum * 100 / maxWorks, 2);
            }
            totalDays = graph.Count;
            average = Math.Round((double)totalWorks / totalDays, 1);
        }

        public int SearchDayByNumber(DateTime date)
        {
            for (int i = 0; i < graph.Count; i++)
            {
                if (graph[i].day.ToShortDateString() == date.ToShortDateString())
                    return i;
            }
            return -1;
        }
    }
}
