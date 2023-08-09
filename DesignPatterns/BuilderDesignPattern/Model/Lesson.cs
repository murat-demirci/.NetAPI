using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace builderdesignpattern.Model
{
    public class Lesson
    {
        public int id;
        public string? name;
        public double? price;
        public double? discountedPrice;
        public bool discountApplied;
        public string? lessonNote;
    }
}