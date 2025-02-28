using Domain.Entities;
using Domain.Enums;
using Action = Domain.Enums.Action;

namespace DomainTests.Bookings;

public class StateMachineTests
{
    public StateMachineTests()
    {
        // Setup code here
    }

    [Fact]
    public void ShoudAlwaysStartWhithCreatedStatus()
    {
        var booking = new Booking();

        Assert.Equal(Status.Created, booking.CurrentStatus);
    }

    [Fact]
    public void ShoudSetStatusToPaidWhenPayingForABookingWhithCreatedStatus()
    {
        var booking = new Booking();
        booking.ChangeState(Action.Pay);

        Assert.Equal(Status.Paid, booking.CurrentStatus);
    }

    [Fact]
    public void ShoudSetStatusToCanceledWhenCancelingABookingWhithCreatedStatus()
    {
        var booking = new Booking();
        booking.ChangeState(Action.Cancel);

        Assert.Equal(Status.Canceled, booking.CurrentStatus);
    }

    [Fact]
    public void ShoudSetStatusToFinishedWhenPaidABooking()
    {
        var booking = new Booking();
        booking.ChangeState(Action.Pay);
        booking.ChangeState(Action.Finish);

        Assert.Equal(Status.Finished, booking.CurrentStatus);
    }

    [Fact]
    public void ShoudSetStatusToRefoundedWhenPaidABooking()
    {
        var booking = new Booking();
        booking.ChangeState(Action.Pay);
        booking.ChangeState(Action.Refund);

        Assert.Equal(Status.Refunded, booking.CurrentStatus);
    }

    [Fact]
    public void ShoudSetStatusToCreatedWhenReopeningCanceledABooking()
    {
        var booking = new Booking();
        booking.ChangeState(Action.Cancel);
        booking.ChangeState(Action.Reopen);

        Assert.Equal(Status.Created, booking.CurrentStatus);
    }

    [Fact]
    public void ShouldNotChangeStatusWhenRefoundingABookingWithCreatedStatus()
    {
        var booking = new Booking();

        booking.ChangeState(Action.Refund);

        Assert.Equal(Status.Created, booking.CurrentStatus);
    }

    [Fact]
    public void ShouldNotChangeStatusWhenRefoundingAFinishedBookin()
    {
        var booking = new Booking();

        booking.ChangeState(Action.Pay);
        booking.ChangeState(Action.Finish);
        booking.ChangeState(Action.Refund);

        Assert.Equal(Status.Finished, booking.CurrentStatus);
    }
}
