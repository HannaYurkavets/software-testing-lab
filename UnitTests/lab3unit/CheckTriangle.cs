
namespace TriangleTest
{
    public class CheckTriangle
    {
        public bool TriangleTest(double a, double b, double c)
        {
            return c < a + b && c > double.MinValue && c < double.MaxValue && c > 0
              && a < b + c && a > double.MinValue && a < double.MaxValue && a > 0
              && b < c + a && b > double.MinValue && c < double.MaxValue && b > 0 ? true : false;
        }
    }
}
