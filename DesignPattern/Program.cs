using DesignPattern;
using DesignPattern.AbstractFactorys;
using DesignPattern.Adapters;
using DesignPattern.bridges;
using DesignPattern.Builders;
using DesignPattern.ChainOfResponsibilitys;
using DesignPattern.Clones;
using DesignPattern.Commands;
using DesignPattern.Composites;
using DesignPattern.Decorators;
using DesignPattern.Facades;
using DesignPattern.FactoryMethods;
using DesignPattern.Flyweights;
using DesignPattern.Iterators;
using DesignPattern.Observers;
using DesignPattern.Proxys;

//IImageReaderFactory imageReaderFactory = new JpgReaderFactory();
//var imageReader = imageReaderFactory.CreateImageReader();
//imageReader.Reader("");
//Address myAddress = new("123 Maple Drive", "Hometown", "StateName", "CountryName", "PostalCode");
//Customer customer = new("苏三", 16, myAddress);

//var cloneCustomer = (Customer)customer.Clone();
//Console.WriteLine($"cloneCustomer address :{cloneCustomer.Address}");
//cloneCustomer.Address.Street = "南山街道";

//Console.WriteLine($"customer address :{customer.Address}");


//IDataConvert dataConvert = new MySqlConverter();
//DataConverter dataConverter = new PdfConverter(dataConvert);
//dataConverter.ParseData("");


//Control window = new Window("MainWindow");

//window.Add(new Button("Button1"));
//window.Add(new Button("Button2"));

//Panel panel = new("Panel");
//panel.Add(new Button("PanelButton1"));
//panel.Add(new Button("PanelButton2"));

//window.Add(panel);

//window.Display(1);

//ReverseOutputEmcryption reverseOutputEmcryption = new();
//reverseOutputEmcryption.Encrypt();

//GameSceneCaretaker gameSceneCaretaker = new();
//GameScene gameScene = new GameScene(1,"奇妙屋", "奇妙屋里真奇妙");
//Console.WriteLine(gameScene);
//gameSceneCaretaker.GameSceneMemento = gameScene.Save();

//gameScene.Description = "欢乐世界真欢乐";
//gameScene.Name = "欢乐世界";

//Console.WriteLine(gameScene);

//Console.WriteLine("****恢复****");
//gameScene.Restore(gameSceneCaretaker.GameSceneMemento);
//Console.WriteLine(gameScene);

//Aircraft aircraft = new Aircraft("直升机", 1);
//ISonicFly sonicFly = new SubSonicFly();
//ITakeOffable takeOffable = new VerticalTakeOff();
//aircraft.TakeOffable = takeOffable;
//aircraft.SonicFly = sonicFly;
//aircraft.TakeOff();
//aircraft.Fly();

//aircraft = new Aircraft("客机", 1);
//takeOffable = new LongDistanceTakeOff();
//aircraft.TakeOffable = takeOffable;
//aircraft.SonicFly = sonicFly;
//aircraft.TakeOff();
//aircraft.Fly();


//User user = new(0);

//user.Play();
//user.Win();
//user.Play();
//user.Win();
//user.Play();
//user.Win();
//user.Play();
//user.Win();
//user.Play();
//user.Defeat();
//user.Play();
//user.Win();
//user.Play();
//user.Win();

//JdbcDatabaseHelper defaultDatabaseHelper = new();
//defaultDatabaseHelper.Handle("select * from a",DatabaseOperation.Query);


//DatabasePool databasePool = new();
//databasePool.Handle("Update * from a", DatabaseOperation.Update);


//using DesignPattern.Singletons;

//DatabasePool databasePool = DatabasePool.GetInstance(3);
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(databasePool.GetConnection());
//} 


//using DesignPattern.SimpleFactorys;

//var shape = ShapeFactory.CreateShape("cricle");
//shape.Draw();
//shape.Erase();  

//shape = ShapeFactory.CreateShape("rectangle");
//shape.Draw();
//shape.Erase();


//AndroidControllerFactory androidControllerFactory = new AndroidControllerFactory();
//var  operationController = androidControllerFactory.CreateOperationController();
//var  interfaceController = androidControllerFactory.CreateController();

//operationController.OperationControl();
//interfaceController.InterfaceControl();


//VideoPlayerBuilder videoPlayerBuilder = new FullModeVideoPlayerBuilder();
//Director director = new(videoPlayerBuilder);
//director.Construct();

//EncryptorAdapter encryptorAdapter = new EncryptorAdapter();
//Console.WriteLine(encryptorAdapter.Encrypt("aa"));

//EncryptorBAdapter encryptorBAdapter = new EncryptorBAdapter();
//Console.WriteLine(encryptorBAdapter.Encrypt("bb"));


//DataBackupFacade dataBackupFacade = new();
//dataBackupFacade.Backup();


//DocumentEditor ducumentEditor = new();
//ducumentEditor.InsertMultimedia("a",new MultimediaContext() { X = 1,Y = 2 });



//GeneralManager generalManager = new("泽纯bb", "普宁第一富婆",null);
//Manager manager = new("李四", "摸鱼的经理", generalManager);
//DesignPattern.ChainOfResponsibilitys.Director director = new("张三", "可恶的主任", manager);

//director.LeaveApproval(29);


//List<string> imageUrls = new List<string>
//        {
//            "image1.jpg", "image2.png", "image3.gif"
//        };

//var viewer = new ImageViewer();
//viewer.LoadImage(imageUrls);
//viewer.DisplayImage();

//Console.ReadKey();

//BoardScreen boardScreen = new();
//ICommand command = new OpenCommand(boardScreen);
//MenuItem menuItem = new MenuItem(command);

//Menu menu = new Menu();
//menu.AddMenuItem(menuItem);
//menuItem.Click();

//var data = Enumerable.Range(1, 100).ToList();

//var pagedIterator = new PagedIterator<int>(data, 10);

//while (pagedIterator.HasNextPage())
//{
//	foreach (var item in pagedIterator.NextPage())
//	{
//        Console.Write(item + " ");
//    }
//    Console.WriteLine();
//}


//Shareholders shareholders = new Shareholders("张三");
//Shareholders ls = new("李四");

//Subject subject = new FlushSubject();
//subject.Attach(shareholders);
//subject.Attach(ls);

//subject.Notify(5, 250);

//subject.Detach(shareholders);
//subject.Notify(10, 500);

