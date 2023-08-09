using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using builderdesignpattern.Builder;

namespace builderdesignpattern
{
    public class LessonDirector
    {
        private readonly LessonBuilder _lessonBuilder;

        public LessonDirector(LessonBuilder lessonBuilder)
        {
            _lessonBuilder = lessonBuilder;
        }

        public void Make(){
            _lessonBuilder.GetLesson();
            _lessonBuilder.ApplyDiscount();
            _lessonBuilder.AddLessonNote();
        }
    }
}