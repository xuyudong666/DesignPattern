using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mementos
{
    public class GameSceneCaretaker
    {
        public GameSceneCaretaker()
        {
            GameSceneMemento = new GameSceneMemento();
        }

        public GameSceneMemento GameSceneMemento { get; set; }
    }
}
