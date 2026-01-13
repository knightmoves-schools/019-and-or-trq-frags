namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Create_A_Method_Named_Taxable_That_Takes_Two_Parameters_State_And_TaxExempt_And_Returns_The_String_Is_Taxable_If_The_State_Is_IA_AND_TaxExempt_IS_False(){
        var verifier = new Verifier();
        Assert.Equal("is taxable", verifier.Taxable("IA", false));
    }

    [Fact]
    public void Should_Return_An_Empty_String_From_Taxable_If_The_State_IS_IA_And_TaxExempt_IS_False(){
        var verifier = new Verifier();
        Assert.Equal("", verifier.Taxable("FL", false));
    }

    [Fact]
    public void Should_Return_An_Empty_String_From_Taxable_If_The_State_IS_FL_And_TaxExempt_IS_True(){
        var verifier = new Verifier();
        Assert.Equal("", verifier.Taxable("FL", true));
    }

    [Fact]
    public void Should_Create_A_Method_Named_IsVehicle_That_Takes_Three_Parameters_HasWheels_CanFly_CanSwim_And_Returns_The_String_Is_Vehicle_If_At_Least_One_Of_The_Three_Parameters_Evaluates_To_True(){
        var verifier = new Verifier();
        Assert.Equal("is vehicle", verifier.IsVehicle(true, true, true));
    }

    [Fact]
    public void Should_Return_The_String_Is_Vehicle_From_IsVehicle_When_HasWheels_Is_True_And_CanFly_And_CanSwim_Are_Both_False(){
        var verifier = new Verifier();
        Assert.Equal("is vehicle", verifier.IsVehicle(true, false, false));
    }

    [Fact]
    public void Should_Return_The_String_Is_Vehicle_From_IsVehicle_When_CanFly_Is_True_And_HasWheels_And_CanSwim_Are_Both_False(){
        var verifier = new Verifier();
        Assert.Equal("is vehicle", verifier.IsVehicle(false, true, false));
    }

    [Fact]
    public void Should_Return_The_String_Is_Vehicle_From_IsVehicle_When_CanSwim_Is_True_And_CanFly_And_HasWheels_Are_Both_False(){
        var verifier = new Verifier();
        Assert.Equal("is vehicle", verifier.IsVehicle(false, false, true));
    }

    [Fact]
    public void Should_Return_The_String_Is_Vehicle_From_IsVehicle_When_CanSwim_And_CanFly_Are_Both_True_And_HasWheels_Is_False(){
        var verifier = new Verifier();
        Assert.Equal("is vehicle", verifier.IsVehicle(false, true, true));
    }

    [Fact]
    public void Should_Return_An_Empty_String_From_IsVehicle_When_HasWheels_CanFly_And_CanSwim_Are_All_False(){
        var verifier = new Verifier();
        Assert.Equal("is vehicle", verifier.IsVehicle(false, true, true));
    }
}