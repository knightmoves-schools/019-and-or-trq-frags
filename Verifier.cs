namespace knightmoves;
public class Verifier
{
    public string Taxable(string state, bool taxExempt)
    {
        if (state == "IA" && !taxExempt)
            return "is taxable";
        return "";
    }

    public string IsVehicle(bool hasWheels, bool canFly, bool canSwim)
    {
        if (hasWheels || canFly || canSwim)
            return "is vehicle";
        return "";
    }
}
