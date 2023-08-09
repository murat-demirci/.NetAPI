using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using builderdesignpattern.Model;

namespace builderdesignpattern.Builder
{
    public abstract class LessonBuilder
    {
        public Lesson? lesson;

        public abstract void GetLesson();
        public abstract void ApplyDiscount();
        public abstract void AddLessonNote();
        public abstract Lesson GetResult();
    }
}