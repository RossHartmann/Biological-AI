using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Metrics;

namespace GeneticFaraday.Models.Metrics
{
    public struct MetricsValueIdentifier : IMetricsValueIdentifier
    {
        /// <summary>
        /// The Identifier
        /// </summary>
        public string Identifier { get; private set; }

        public MetricsValueIdentifier(string identifier)
            : this()
        {
            this.Identifier = identifier;
        }

        public bool Equals(IMetricsValueIdentifier other)
        {
            if (other == null)
                return false;
            else if (other is MetricsValueIdentifier)
                return this.Identifier == ((MetricsValueIdentifier)other).Identifier;
            else
                return false;
        }

        public static bool operator ==(MetricsValueIdentifier metricsValueIdentifierOne, MetricsValueIdentifier metricsValueIdentifierTwo)
        {
            return metricsValueIdentifierOne.Equals(metricsValueIdentifierTwo);
        }

        public static bool operator !=(MetricsValueIdentifier metricsValueIdentifierOne, MetricsValueIdentifier metricsValueIdentifierTwo)
        {
            return !(metricsValueIdentifierOne == metricsValueIdentifierTwo);
        }

        public bool Equals(MetricsValueIdentifier other)
        {
            return string.Equals(Identifier, other.Identifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is MetricsValueIdentifier && Equals((MetricsValueIdentifier)obj);
        }

        public override int GetHashCode()
        {
            return (Identifier != null ? Identifier.GetHashCode() : 0);
        }
    }
}
