using UnityEngine;

namespace AbstractFactory.Factory
{
    public class Warrior : Character
    {
        private WarriorFactory _factory;
        public override void Start()
        {
            _factory = FindObjectOfType(typeof(WarriorFactory)) as WarriorFactory;
            if (_factory==null) return;
            
            base.Factory = this._factory;
            base.Start();
        }
    }
}