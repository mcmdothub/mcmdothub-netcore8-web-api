# mcmdothub-netcore8-web-api

- Create an empty solution "Netcore8WebAPI"

- Add 3 folders: 
	- Core
	- Infrastructure
	-Presentation
-------------------------------------------------------------------------------------------------------------	
- Add new project class library "Netcore8WebAPI.Domain" inside folder "Core"
	- Create folder "Common"
		- Add class "BaseEntity" inside folder "Common"
		- Add class "AuditableBaseEntity" inside folder "Common"
	- Create folder "Entities"
		- Add class "Entity" inside folder "Entities"
		- Add class "Student" inside folder "Entities"
		- Add class "Position" inside folder "Entities"
		- Add class "Employee" inside folder "Entities"
		- Add class "Department" inside folder "Entities"
		- Add class "SalaryRange" inside folder "Entities"
		
	- Create folder "Enums"
		- Add class "Gender" inside folder "Enums"
		
	- Create folder "Settings"
		- Add class "MailSettings" inside folder "Settings"				// will use inside project "Netcore8WebAPI.Infrastructure.Shared" file "ServiceRegistration.cs"
		- Add class "JWTSettings" inside folder "Settings"				// will use inside project "Netcore8WebAPI.Infrastructure.Shared" file "ServiceRegistration.cs"
	
	- Create class "Using"
-------------------------------------------------------------------------------------------------------------
- Add new project class library "Netcore8WebAPI.Application" inside folder "Core"
	- Add project reference to: "Netcore8WebAPI.Domain"
	- Add Nuget Packages:
		- LinqKit.Microsoft.EntityFrameworkCore
		- MediatR											// for class ValidationBehavior
		- FluentValidation									// for class ValidationBehavior
		- AutoMapper
		- Scrutor											// for ServiceExtensions (for Scan)
		
	- Create folder "Interfaces"
		- Add class "IDateTimeService" inside folder "Interfaces"									// To Implement in Infrastructure/Shared
		
		- Add class "IGenericRepositoryAsync" inside folder "Interfaces"							// To Implement in Infrastructure/Persistence

	- Create folder "Exceptions"
		- Add class "ApiException" inside folder "Exceptions"
		- Add class "ValidationException" inside folder "Exceptions"
		
	- Create folder "Behaviours"
		- Add class "ValidationBehavior" inside folder "Behaviours"
		
	- Create folder "Parameters"
		- Add class "ListParameter" inside folder "Parameters"
		
	- Create folder "Repositories" inside folder "Interfaces"
		- Add class "IDepartmentRepositoryAsync" inside folder "Repositories"
	
	- Add class "IModelHelper" inside folder "Interfaces"
		
	- Create folder "Features"
		- Create folder "Departments"
			- Create folder "Queries"
				- Create folder "GetDepartments"
					- Add class "GetDepartmentsViewModel" inside folder "GetDepartments"
					- Add class "GetDepartmentsQuery" inside folder "GetDepartments"
	
	- Add class "PagingParameter" inside folder "Parameters"
	- Add class "QueryParameter" inside folder "Parameters"
	- Add class "RecordsCount" inside folder "Parameters"
	- Add class "SortOrder" inside folder "Parameters"
	- Add class "Search" inside folder "Parameters"
	- Add class "Column" inside folder "Parameters"
	
	- Create folder "Wrappers"
		- Add class "Response" inside folder "Wrappers"
		- Add class "PagedResponse" inside folder "Wrappers"
		- Add class "PagedDataTableResponse" inside folder "Wrappers"
	
	- Create folder "Employees" inside folder "Features"
		- Create folder "Queries"
			- Create folder "GetEmployees"
				- Add class "GetEmployeesViewModel" inside folder "GetEmployees"
				- Add class "PagedEmployeesQuery" inside folder "GetEmployees"
				
				- Add class "IEmployeeRepositoryAsync" inside folder "Interfaces/Repositories"
				- Add class "GetEmployeesQuery" inside folder "GetEmployees"
	
	- Create folder "Positions" inside folder "Features"
		- Create folder "Queries"
			- Create folder "GetPositions"
				- Add class "GetPositionsViewModel" inside folder "GetPositions"
				- Add class "PagedPositionsQuery" inside folder "GetPositions"
				
				- Add class "GetPositionsQuery" inside folder "GetPositions"
		
		- Create folder "Commands"
			- Create folder "CreatePosition"
				- Add class "CreatePositionCommand" inside folder "CreatePosition"
				- Add class "CreatePositionCommandValidator" inside folder "CreatePosition"
				
				- Add class "ISalaryRangeRepositoryAsync" inside folder "Interfaces/Repositories"
				- Add class "InsertMockPositionCommand" inside folder "CreatePosition"
				
			- Create folder "DeletePositionById"
				- Add class "DeletePositionByIdCommand" inside folder "DeletePositionById"
				
			- Create folder "UpdatePosition"
				- Add class "UpdatePositionCommand" inside folder "UpdatePosition"
				- Add class "UpdatePositionCommandValidator" inside folder "UpdatePosition"
				
	- Create folder "SalaryRanges" inside folder "Features"
		- Create folder "Queries"
			- Create folder "GetSalaryRanges"
				- Add class "GetSalaryRangesViewModel" inside folder "GetSalaryRanges"
				- Add class "GetSalaryRangesQuery" inside folder "GetSalaryRanges"
				
	- Add class "IPositionRepositoryAsync" inside folder "Interfaces/Repositories"	
	
	- Create folder "GetPositionById" inside folder "Positions/Queries"
		- Add class "GetPositionByIdQuery" inside folder "GetPositionById"
	
	- Add class "IDataShapeHelper" inside folder "Interfaces"
	
	- Create folder "Helpers"
		- Add class "DataShapeHelper" inside folder "Helpers"
		- Add class "ModelHelper" inside folder "Helpers"
		
	- Create folder "DTOs"
		- Create folder "Email"
			- Add class "EmailRequest" inside folder "Email"
		
	- Add class "IEmailService" inside folder "Interfaces"		=> you will use it inside project "Netcore8WebAPI.Infrastructure.Shared" inside class "ServiceRegistration.cs"
	- Add class "IMockService" inside folder "Interfaces"		=> you will use it inside project "Netcore8WebAPI.Infrastructure.Shared" inside class "ServiceRegistration.cs"
	
	- Create folder "Mappings"
		- Add class "GeneralProfile" inside folder "Mappings"
		
	- Create folder "Enums"
		- Add class "Roles" inside folder "Enums"
		
	- Create class "ServiceExtensions" => you will use it inside project WebAPI inside class "Program.cs": builder.Services.AddApplicationLayer();
	
	- Create class "Using"
-------------------------------------------------------------------------------------------------------------
- Add new project class library "Netcore8WebAPI.Infrastructure.Shared" inside folder "Infrastructure"
	- Add project reference to: "Netcore8WebAPI.Application"
	
	- Add Nuget Packages:
		- Microsoft.Extensions.Logging
		- Microsoft.Extensions.Options.ConfigurationExtensions
		- MimeKit													// for "EmailService" here "new MimeMessage();"
		- MailKit													// for "EmailService" here "Connect" here "smtp.Connect" and "SecureSocketOptions" and "Authenticate" and "SendAsync" and "Disconnect"
		
	- Create folder "Services"
		- Add class "DateTimeService" inside folder "Services"
		
		- Add class "EmailService" inside folder "Services"		=> you will use it inside project "Netcore8WebAPI.Infrastructure.Shared" inside class "ServiceRegistration.cs"
		- Add class "MockService" inside folder "Services"		=> you will use it inside project "Netcore8WebAPI.Infrastructure.Shared" inside class "ServiceRegistration.cs"

	- Create class "ServiceRegistration" => you will use it inside project WebAPI inside class "Program.cs": builder.Services.AddSharedInfrastructure(builder.Configuration);
	- Create class "Using"
-------------------------------------------------------------------------------------------------------------
- Add new project class library "Netcore8WebAPI.Infrastructure.Persistence" inside folder "Infrastructure"		
	- Add Nuget Packages:
		- Microsoft.EntityFrameworkCore
		- Microsoft.EntityFrameworkCore.SqlServer
		- Microsoft.Extensions.Options.ConfigurationExtensions				// for "ServiceRegistration.cs": "GetValue" here "configuration.GetValue<bool>("UseInMemoryDatabase")"
		- Microsoft.EntityFrameworkCore.InMemory							// for "ServiceRegistration.cs": "UseInMemoryDatabase"
		- LinqKit.Microsoft.EntityFrameworkCore
		- System.Linq.Dynamic.Core
		
	- Add project reference to: "Netcore8WebAPI.Application" & "Netcore8WebAPI.Domain"
		
	- Create folder "Contexts"
		- Add class "ApplicationDbContext" inside folder "Contexts"
		- Add class "ApplicationDbContextHelpers" inside folder "Contexts"
		
	- Create folder "Repository"
		- Add class "GenericRepositoryAsync" inside folder "Repository"
		- Add class "DepartmentRepositoryAsync" inside folder "Repository"
		- Add class "PositionRepositoryAsync" inside folder "Repository"
		- Add class "SalaryRangeRepositoryAsync" inside folder "Repository"

	- Create class "ServiceRegistration" => you will use it inside project WebAPI inside class "Program.cs": builder.Services.AddPersistenceInfrastructure(builder.Configuration);
	
	- Create class "Using"
-------------------------------------------------------------------------------------------------------------
- Add new project class library "Netcore8WebAPI.WebApi" inside folder "Presentation"
	- Add project reference to: "Netcore8WebAPI.Infrastructure.Persistence"
	- Add project reference to: "Netcore8WebAPI.Infrastructure.Shared"
	
	- Add Nuget Packages:
		- Serilog.AspNetCore
		- Serilog.Expressions												// inside "Program.cs" with "Log"
		- Asp.Versioning.Mvc.ApiExplorer									// used inside ServiceExtensions
		- Microsoft.AspNetCore.Authentication.JwtBearer						// used inside ServiceExtensions
		- AspNetCore.HealthChecks.SqlServer
		- IdentityModel
		- Microsoft.EntityFrameworkCore.Design
		- Microsoft.EntityFrameworkCore.Tools
		- Microsoft.Extensions.Diagnostics.HealthChecks.EntityFrameworkCore
		- Swashbuckle.AspNetCore.Swagger
		
	
	- Create folder "Middlewares"
		- Add class "ErrorHandlerMiddleware" inside folder "Middlewares"
		
	- Create folder "Extensions"
		- Add class "AppExtensions" inside folder "Extensions"				// inside "Program.cs": app.UseSwaggerExtension();
																			// inside "Program.cs": app.UseErrorHandlingMiddleware();
		- Add class "AuthorizationConsts" inside folder "Extensions"		
		
		- Add class "ServiceExtensions" inside folder "Extensions"			// inside "Program.cs": builder.Services.AddSwaggerExtension(); 

	- Create folder "Controllers"
		- Add class "BaseApiController" inside folder "Controllers"
		- Add class "MetaController" inside folder "Controllers"
		
		- Create folder "v1"
			- Add class "DepartmentsController" inside folder "v1"
			- Add class "EmployeesController" inside folder "v1"
			- Add class "PositionsController" inside folder "v1"
			- Add class "SalaryRangesController" inside folder "v1"
			
	- Create folder "Models"
		- Add class "Metadata" inside folder "Models"

	- Create class "Using"
-------------------------------------------------------------------------------------------------------------

Adding Mock Data & Bogus