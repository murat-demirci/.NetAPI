using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using builderdesignpattern.Builder;
using builderdesignpattern.Model;

namespace builderdesignpattern
{
    public class NewStudentLessonBuilder : LessonBuilder
    {
        public override void GetLesson()
        {
            lesson = new Lesson
            {
                id = 1,
                name = "Artificial Intelligence -  Beginner to Advanced in 10 Minute.",
                price = 49.99
            };
        }   
        public override void AddLessonNote()
        => lesson!.lessonNote = "Hey, welcome. Your discount code has been applied!";

        public override void ApplyDiscount()
        {
            lesson!.discountedPrice = lesson.price * 0.5;
            lesson.discountApplied = true;
        }
        public override Lesson GetResult()
        => lesson!;
    }
}