﻿using DesignPattern;
using DesignPattern.AbstractFactorys;
using DesignPattern.Builders;
using DesignPattern.Clones;
using DesignPattern.FactoryMethods;

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


VideoPlayerBuilder videoPlayerBuilder = new FullModeVideoPlayerBuilder();
Director director = new(videoPlayerBuilder);
director.Construct();


