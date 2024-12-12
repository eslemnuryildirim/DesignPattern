using System;

namespace StatePattern.State1
{
    public interface ITrafficLightState
    {
        void Change(TrafficLight trafficLight);
    }

    public class TrafficLight
    {
        private ITrafficLightState _state;

        public TrafficLight(ITrafficLightState state)
        {
            _state = state;
        }

        public void SetState(ITrafficLightState state)
        {
            _state = state;
        }

        public void Change()
        {
            _state.Change(this);
        }
    }

    public class RedState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            Console.WriteLine("Kırmızı ışık: Dur!");
            trafficLight.SetState(new GreenState());
        }
    }

    public class GreenState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            Console.WriteLine("Yeşil ışık: Geç!");
            trafficLight.SetState(new YellowState());
        }
    }

    public class YellowState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            Console.WriteLine("Sarı ışık: Bekle!");
            trafficLight.SetState(new RedState());
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // İlk trafik ışığı durumunu belirle
            TrafficLight trafficLight = new TrafficLight(new RedState());

            // Durum değişikliklerini simüle et
            for (int i = 0; i < 6; i++) // Döngü sayısını artırabilirsiniz
            {
                trafficLight.Change();
            }

            Console.ReadLine(); // Konsolun açık kalmasını sağlar
        }
    }
}
