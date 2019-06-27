using Xunit;

namespace Vehicle.UnitTests
{
    public class car
    {
        [Fact]
        public void car_can_start()
        {
            // arrange
            var subject = new Car();
            // act
            subject.Start();
            // assert
            Assert.True(subject.Started, "Car hasn't started");
        }

        [Fact]
        public void car_can_stop()
        {
            // TODO: arrange
            var subject = new Car();
            // TODO: act
            subject.Start();
            subject.Stop();
            // TODO: assert
            Assert.False(subject.Started, "Car hasn't stopped");
        }

        [Fact]
        public void car_cannot_move_forward_if_not_started()
        {
            // TODO: arrange
            var subject = new Car();
            // TODO: act
            
            // TODO: assert
            Assert.Throws<Vehicle.CarNotStartedException>(()=>subject.MoveForward());
        }

        [Fact]
        public void car_has_already_started()
        {
            // TODO: arrange
            var subject = new Car();
            // TODO: act
            subject.Start();
            // TODO: assert
            Assert.Throws<Vehicle.CarAlreadyStartedException>(()=>subject.Start());
        }

        [Theory]
        [InlineData(5, 5)]
        // TODO: More data to be added
        public void car_can_move_forward_and_consumes_petrol(int timesToMoveForward, int expectedPetrolLitresConsumed)
        {
            // arrange
            var subject = new Car();
            subject.Start();

            // act
            while (timesToMoveForward > 0)
            {
                subject.MoveForward();
                timesToMoveForward--;
            }

            // assert
            Assert.Equal(expectedPetrolLitresConsumed, subject.PetrolLitresConsumed);
        }
    }
}
