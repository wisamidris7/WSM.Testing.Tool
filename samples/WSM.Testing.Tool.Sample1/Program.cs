using WSM.Testing.Tool.Sample1;

using AppDbContext appDbContext = new();
appDbContext.SeedSections();
appDbContext.SeedEmployees();