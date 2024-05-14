using AutoFixture;
using LibraryShapes;
using LibraryShapes.exception;
using LibraryShapes.interfaces;
using Moq;

namespace LibraryShapes.UnitTest
{
    public class ShapeUnitTest
    {

        [Theory]
        [InlineData(10, 100)]
        [InlineData(2.2, 4.84)]
        [InlineData(0, 0)]
        public void CircleArea_Retuns_Positive_SameNumber_Sucess(double input, double expected)
        {
            //arrange
            ShapeHandler handler = new ShapeHandler();
            // констовая Пи в площади круга
            expected = Math.Round(expected * 3.14);
            //act
            double result = handler.CalculateArea(new Circle(input));
            //assert
            Assert.Equal(result,expected);
        }
        [Theory]
        [InlineData(-100)]
        [InlineData(-5.4101023)]
        public void CircleArea_Throw_Exception_When_Get_NegativeNumber_Sucess(double input)
        {
            //arrange 
            ShapeHandler handler = new ShapeHandler();

            //assert
            Assert.Throws<NegativeNumberException>(()=>handler.CalculateArea(new Circle(input)));
        }
        [Theory]
        [InlineData(2,2,2,   2)]
        [InlineData(3.5,3.5,3.5,  5)]
        public void TriangleAre_Retuns_Positive_SameNumber_Sucess(double aSide,double bSide,double cSide, double expected)
        {
            //arrange
            ShapeHandler handler = new ShapeHandler();
            // констовая Пи в площади круга
            //act
            double result = handler.CalculateArea(new Triangle(aSide,bSide,cSide));
            //assert
            Assert.Equal(result, expected);
        }
        [Theory]
        [InlineData(-2, -2, -2)]
        [InlineData(-3.5, -3.5, -3.5)]
        public void TriangleArea_Throw_Exception_When_Get_NegativeNumber_Sucess(double aSide, double bSide, double cSide)
        {
            //arrange 
            ShapeHandler handler = new ShapeHandler();

            //assert
            Assert.Throws<NegativeNumberException>(() => handler.CalculateArea(new Triangle(aSide,bSide,cSide)));
        }
        // методу CheckRightTriangle известно, что значения в aSide всегда больше, чем у других ( не знаю как написать логику,
        // где высчитывается большая сторона и при этом считается теорема пифагора) 
        [Theory]
        [InlineData(2, 2, 2)]
        public void CheckRightTriangle_return_true(double aSide, double bSide, double cSide)
        {
            //arrange 
            Triangle triangle = new Triangle(aSide,bSide,cSide);
            //act
            var expected=triangle.CheckRightTriangle();

            //assert
            Assert.True(expected);
            
        }
    }
}