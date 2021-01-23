namespace AbstractFactory.Factory
{
    public class Healer : Character
    {
        private HealerFactory _factory;
        public override void Start()
        {
            _factory = FindObjectOfType(typeof(HealerFactory)) as HealerFactory;
            if (_factory==null) return;
            
            base.Factory = this._factory;
            base.Start();
        }
    }
}