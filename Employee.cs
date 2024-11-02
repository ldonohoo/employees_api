public class Employee 
{
    public int Id { get; set; }
    // the next two are required because otherwise with nullability
    // turned on, c# wants you to GUARANTEE that the field 
    // is NOT NULL when exiting the constructor
    //
    // two options- either 
    //   - ENABLE the field to be null by using
    //       public string FirstName { get; set; } (we will not use this
    //       option because FirstName logicially shouldn't be null) 
    //   - OR require the field to be entered with required keyword  
    public required string FirstName { get; set; }
    public required string LastName { get; set; }


}