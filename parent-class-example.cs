class Member
{
    protected in annualFee;
    private string name;
    private int memberID;
    private int memberSince;

    public overide string ToString
    {
        return "\nName: " + name + "\nMember ID: + memberID" + "\nMember Since: " + memberSince + "\nTotal Annual Fee: " + annualFee;
    }


    // Constructors
    public Member()
    {
        Console.WriteLine("Parent Constructor with no params.");
    }

    public Member(string pName, int pMemberID, int pMemberSince)
    {
        Console.WriteLine("Parent Constructor with 3 params.");
        name = pName;
        memberID = pMemberID;
        memberSince = pMemberSince;
    }

}


class NormalMem : Member
{
    public NormalMem(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
    {
        Console.WriteLine("Child constructor with 4 params");
        Console.WriteLine("Remarks = {0}", remarks);
    }
}
