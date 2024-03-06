using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mementos
{
    public class GameScene
    {
        public GameScene()
        {

        }

        public GameScene(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GameSceneMemento Save()
        {
            return new GameSceneMemento(Id, Name, Description);
        }

        public void Restore(GameSceneMemento gameSceneMemento)
        {
            Id = gameSceneMemento.Id;
            Name = gameSceneMemento.Name;
            Description = gameSceneMemento.Description;
        }
        public override string ToString()
        {
            return $"当前游戏场景:id ={Id},Name= {Name},Description = {Description}";
        }
    }
}
