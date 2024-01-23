using System;
using System.Diagnostics;

namespace PracticeWebApi.Test {

    public class UnitTest1 {
        [Fact]
        public void Test1() {
            int val = 1;
            Debug.Assert(val != 1, " Value should not be 1.");
        }
    }
}
