using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroSimulator
{
    public class Board
    {
        private static Board instance;
        private List<BaseTask> _tasks;
        
        private Board()
        {
            //TODO: implement generating tasks list 
            _tasks = new List<BaseTask>();
        }

        public static Board GetInstance()
        {
            if(instance == null)
            {
                instance = new Board();
            }
            return instance;
        }

        public List<BaseTask> GetTasks()
        {
            return _tasks;
        }
    }
}
