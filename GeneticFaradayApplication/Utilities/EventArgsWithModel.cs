using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts;

namespace GeneticFaradayApplication.Utilities
{
    public class EventArgsWithModel<TModel> : EventArgs
    {
        public TModel Model { get; private set; }

        public EventArgsWithModel(TModel model)
        {
            this.Model = model;
        }
    }
}
