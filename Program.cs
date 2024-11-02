var builder = WebApplication.CreateBuilder(args);

//simple list for data storage 
var employees = new List<Employee>
{
    new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
    new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" }
};
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Manual way of getting context out of the request here:
// app.MapGet("/employees", (HttpContext context) => {
//     context.Request...
//     // once you get the context, you can actually 
//     // read the items and the headers direcly by 
//     // manually by pulling aparth the context object!
//     // we won't be doing it that way however
// });

app.Run();

