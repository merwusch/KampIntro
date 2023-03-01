using OOP3;

ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
ICreditManager transportCreditManager = new TransportCreditManager();
ICreditManager houseCreditManager = new HouseCreditManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService(), new SmsLoggerService() };


ApplicationManager applicationManager = new ApplicationManager();
applicationManager.Apply(personalFinanceCreditManager, loggers);
//applicationManager.Apply(transportCreditManager, loggers);
//applicationManager.Apply(houseCreditManager, loggers);

List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager, transportCreditManager };
//applicationManager.CreditPreInformation(credits);