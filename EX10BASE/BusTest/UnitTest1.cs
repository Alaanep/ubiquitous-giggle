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
        public void TestPutPeopleInBus_60_40_FindPeople()
        {
            bs.PutPeopleInBus(60, 40);
            int result = bs.NrOfPeople;
            Assert.AreEqual(20, result);
        }

        //60 people, 40 seats: 2 busses needed
        [TestMethod]
        public void TestPutPeopleInBus_60_40_FindBusses()
        {
            bs.PutPeopleInBus(60, 40);
            int result = bs.NrOfBuses;
            Assert.AreEqual(2, result);
        }

        //80 seats, 40 people: 2 busses
        [TestMethod]
        public void TestPutPeopleInBus_80_40_FindBusses()
        {
            bs.PutPeopleInBus(80, 40);
            int result = bs.NrOfBuses;
            Assert.AreEqual(2, result);
        }

        //80 seats, 40 people: 40 people in last buss
        [TestMethod]
        public void TestPutPeopleInBus_80_40_FindPeople()
        {
            bs.PutPeopleInBus(80, 40);
            int result = bs.NrOfPeople;
            Assert.AreEqual(40, result);
        }

        //40 seats, 20 people: 1 busses
        [TestMethod]
        public void TestPutPeopleInBus_20_40_FindBusses()
        {
            bs.PutPeopleInBus(20, 40);
            int result = bs.NrOfBuses;
            Assert.AreEqual(1, result);
        }

        //40 seats, 20 people:  20 people
        [TestMethod]
        public void TestPutPeopleInBus_20_40_FindPeople()
        {
            bs.PutPeopleInBus(20, 40);
            int result = bs.NrOfPeople;
            Assert.AreEqual(20, result);
        }

        //20 seats, 40 people: 2 busses
        [TestMethod]
        public void TestPutPeopleInBus_40_20_FindBusses()
        {
            bs.PutPeopleInBus(40, 20);
            int result = bs.NrOfBuses;
            Assert.AreEqual(2, result);
        }

        //20 seats, 40 people:  20 people
        [TestMethod]
        public void TestPutPeopleInBus_40_20_FindPeople()
        {
            bs.PutPeopleInBus(40, 20);
            int result = bs.NrOfPeople;
            Assert.AreEqual(20, result);
        }


    }
}
