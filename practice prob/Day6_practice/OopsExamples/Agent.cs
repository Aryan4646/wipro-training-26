using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Agent
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public double? BusinessAmount { get; set; }
        public double? Status { get; set; }

        public override string ToString()
        {
            return "Agent Id " + AgentId + " Agent Name " + AgentName + " Business Amont " + BusinessAmount + " Status " + Status;
        }

    }
}
