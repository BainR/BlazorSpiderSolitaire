using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSpider.Models
{
    public class Move
    {
        public int FromPileId { get; set; }
        public int ToPileId { get; set; }
        public bool ToCompletedPile { get; set; }
        public bool TurnFaceDown { get; set; }
        public int Cards { get; set; }
    }
}
