namespace MyNetcore8WebAPI.Application.Interfaces
{
    public interface IMockService
    {
        List<Position> GetPositions(int rowCount, IEnumerable<Department> departments, IEnumerable<SalaryRange> salaryRanges);

        List<Employee> GetEmployees(int rowCount);

        List<Position> SeedPositions(int rowCount);
    }
}