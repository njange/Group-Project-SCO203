#include "pch.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest3
{
	TEST_CLASS(UnitTest3)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
#include "pch.h"
#include "CppUnitTest.h"
#include "../ConsoleApplication1/ConsoleApplication1.cpp"   // Update using your project name

            using namespace Microsoft::VisualStudio::CppUnitTestFramework;

            namespace HelloWorldTests
            {
                TEST_CLASS(HelloWorldTests)
                {
                public:

                    TEST_METHOD(TestMethod)
                    {
                        std::string expected = "Hello World!\n";

                        std::stringstream buffer;
                        std::streambuf* sbuf = std::cout.rdbuf(); // Save cout's buffer
                        std::cout.rdbuf(buffer.rdbuf()); // Redirect cout to the stringstream buffer

                        // Call main() in your test
                        int result = main();

                        // When finished, redirect cout to the original buffer 
                        std::cout.rdbuf(sbuf);
                        std::cout << "std original buffer: \n";
                        std::cout << buffer.get();

                        // Test
                        Assert::AreEqual(expected, buffer.str());
                    }
                };
            }
		}
	};
}
