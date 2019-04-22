namespace Strategy
{
    class Car
    {
        private IMovable Movable { get; set; }
        protected int passengersCount; // кол-во пассажиров
        protected string model; // модель автомобиля

        public Car(int passengersCount, string model, IMovable movable)
        {
            this.passengersCount = passengersCount;
            this.model = model;
            Movable = movable;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
