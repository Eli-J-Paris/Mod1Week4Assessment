namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");
            string summary = andysBike.Sumary();
            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles.";
            Assert.Equal(expected, summary);

        }

        // Add more tests here!

        [Fact]
        public void Check_If_DriveMethod_AddsInt()
        {
            Vehicle car = new Vehicle(3, "lemon");
            car.Drive();
            int expected = 5;
            Assert.Equal(expected, car.MilesDriven);
            
        }

        [Fact]
        public void Check_If_PaintMethod_CanChange_CarColor()
        {
            Vehicle car = new Vehicle(3, "lemon");
            car.Paint("a really ugly beige color");
            string expected = "a really ugly beige color";
            Assert.Equal(expected, car.Color);

        }
    }
}