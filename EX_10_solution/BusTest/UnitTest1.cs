using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bus; //namespace for BusSystem class
namespace BusTest
{
    [TestClass]
    public class UnitTest1
    {
        //we do not need TestInitialize method because values for each test are different
        public BusSystem bs = new BusSystem();

        //60 people, 40 seats: 40 people in last buss
        [TestMethod]
        public void TestPutPeopleInBus_60_40_FindPeople_20()
        {
            bs.PutPeopleInBus(60, 40);
            int result = bs.NrOfPeople;
            Assert.AreEqual(result, 20);
        }

        //60 people, 40 seats: 2 busses needed
        [TestMethod]
        public void TestPutPeopleInBus_60_40_FindBusses_2()
        {
            bs.PutPeopleInBus(60, 40);
            int result = bs.NrOfBuses;
            Assert.AreEqual(result, 2);
        }

        //80 seats, 40 people: 2 busses
        [TestMethod]
        public void TestPutPeopleInBus_80_40_FindBusses_2()
        {
            bs.PutPeopleInBus(80, 40);
            int result = bs.NrOfBuses;
            Assert.AreEqual(result, 2);
        }

        //80 seats, 40 people: 40 people in last buss
        [TestMethod]
        public void TestPutPeopleInBus_80_40_FindPeople_40()
        {
            bs.PutPeopleInBus(80, 40);
            int result = bs.NrOfPeople;
            Assert.AreEqual(result, 40);
        }

        //40 seats, 20 people: 1 busses
        [TestMethod]
        public void TestPutPeopleInBus_20_40_FindBusses_1()
        {
            bs.PutPeopleInBus(20, 40);
            int result = bs.NrOfBuses;
            Assert.AreEqual(result, 1);
        }

        //40 seats, 20 people:  20 people
        [TestMethod]
        public void TestPutPeopleInBus_20_40_FindPeople_20()
        {
            bs.PutPeopleInBus(20, 40);
            int result = bs.NrOfPeople;
            Assert.AreEqual(result, 20);
        }

        //20 seats, 40 people: 2 busses
        [TestMethod]
        public void TestPutPeopleInBus_40_20_FindBusses_2()
        {
            bs.PutPeopleInBus(40, 20);
            int result = bs.NrOfBuses;
            Assert.AreEqual(result, 2);
        }

        //20 seats, 40 people:  20 people
        [TestMethod]
        public void TestPutPeopleInBus_40_20_FindPeople_20()
        {
            bs.PutPeopleInBus(40, 20);
            int result = bs.NrOfPeople;
            Assert.AreEqual(result, 20);
        }


    }
}
