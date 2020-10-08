using NUnit.Framework;
using Assignment_8040;

namespace NUnitTestProject1
{
    public class Tests
    {
        private TriangleSolver tri;
        [SetUp]
        public void Setup()
        {
           // create an object to check the values
            tri = new TriangleSolver();
        }

        [Test]

       // Test case 1, to check Equilateral!!!
       public void Equilateral()
        {
            int x = 10, y = 10, z = 10;          
            int expected_result = 0;    // In Analyze funtion, for Equilateral our return value is 0;
            int actual_result = tri.Analyze(x, y,z); 
            Assert.AreEqual(expected_result, actual_result);
        }

        // Test case 2, to check Isosceles!!!
       public void Isosceles()
        {
            int x = 2, y = 3, z = 3;
            int expected_result = 1;  // In Analyze funtion, for Isosceles our return value is 1;
            int actual_result = tri.Analyze(x, y, z);
            Assert.AreEqual(expected_result, actual_result);
        }

        // Test case 3, to check Scalene!!!
        public void Scalene()
        {
            int x = 7, y = 9, z = 12;
            int expected_result = 2;  // In Analyze funtion, for Equilateral our return value is 2;
            int actual_result = tri.Analyze(x, y, z);
            Assert.AreEqual(expected_result, actual_result);
        }

        // Test case 4, to check Unable_Triangle!!!
       public void Unable_Triangle()
        {
            int x = 4, y = 8, z = 15;
            int expected_result = 3;  // In Analyze funtion, for unable triangle our return value is 2;
            int actual_result = tri.Analyze(x, y, z);
            Assert.AreEqual(expected_result, actual_result);
        }

        // Test case 5, to check Negative_value!!!
        public void Negative_value()
        {
            int x = -5, y = -9, z = 6;
            int expected_result = 3;  // In Analyze funtion, for unable triangle our return value is 2; 
            int actual_result = tri.Analyze(x, y, z);
            Assert.AreEqual(expected_result, actual_result);
        }

        // Test case 6, to check wrong input for Equilateral triange!!!
        public void wrong_value()
        {
            int x = 7, y = 9, z = 7;
            int expected_result = 2;  // In Analyze funtion, for Equilateral our return value is 0;
            int actual_result = tri.Analyze(x, y, z);
            Assert.AreEqual(expected_result, actual_result);
        }

        // Test case 7, to check 0 input!!!
        public void Value_0()
        {
            int x = 0, y = 0, z = 0;
            int expected_result = 3; 
            int actual_result = tri.Analyze(x, y, z);
            Assert.AreEqual(expected_result, actual_result);
        }

        // Test case 8, to check right input to wrong output!!!
        public void Riht_input_to_wrong_output()
        {
            int x = 15, y = 18, z = 16;
            int expected_result = 3; // For unable Triangle return is 3!!!
            int actual_result = tri.Analyze(x, y, z);
            Assert.AreEqual(expected_result, actual_result);
        }

    }
}