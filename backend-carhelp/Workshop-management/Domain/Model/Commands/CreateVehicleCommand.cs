namespace backend_carhelp.Workshop_management.Domain.Model.Commands;

public record CreateVehicleCommand(string Plate, string Brand, string Model,string Year, string Colour, string ImageUrl, string Mileage);