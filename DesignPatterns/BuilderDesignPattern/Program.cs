using builderdesignpattern;
using builderdesignpattern.Builder;
using builderdesignpattern.Model;

LessonBuilder lessonBuilder = new NewStudentLessonBuilder();

LessonDirector lessonDirector= new LessonDirector(lessonBuilder);
lessonDirector.Make();

Lesson lesson = lessonBuilder.GetResult();
 Console.WriteLine($"{lesson.name} {lesson.price} {lesson.discountedPrice}");