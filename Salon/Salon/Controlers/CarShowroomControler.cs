using Salon.Api;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Controlers
{
    public class CarShowroomControler
    {
        public CarShowroomControler() { }

        public async void AddCarShowroom(CarShowroom carshowroom)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync("api/CarShowroom", carshowroom))
            {
                if (response.IsSuccessStatusCode) { }
                else { throw new Exception(response.ReasonPhrase); }
            }
        }

        public async Task<CarShowroom> GetCarShowroom(int carshowroomId)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/CarShowrooms/" + carshowroomId))
            {
                if (response.IsSuccessStatusCode)
                {
                    CarShowroom carShowroom = await response.Content.ReadAsAsync<CarShowroom>();
                    return carShowroom;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<CarShowroom> GetCarShowroom(string name)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/CarShowrooms"))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<CarShowroom> carShowroomList = await response.Content.ReadAsAsync<List<CarShowroom>>();
                    return carShowroomList.Where(c => c.Name == name).FirstOrDefault();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<List<CarShowroom>> GetCarshowrooms()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/CarShowrooms"))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<CarShowroom> carShowroomList = await response.Content.ReadAsAsync<List<CarShowroom>>();
                    return carShowroomList;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async void UpdateCarShowroom(CarShowroom carshowroom)
        {
            try
            {
                Task<CarShowroom> newCarShowroomTask = GetCarShowroom(carshowroom.CarShowroomId);
                CarShowroom newCarShowroom = await newCarShowroomTask;

                if (newCarShowroom == null)
                    throw new EntryPointNotFoundException("Vehiclee Not found in database");

                newCarShowroom.Name = carshowroom.Name;
                newCarShowroom.MaxCapacity = carshowroom.MaxCapacity;
      
                using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync("api/CarShowrooms/" + carshowroom.CarShowroomId, newCarShowroom))
                {
                    if (response.IsSuccessStatusCode) { }
                    else { throw new Exception(response.ReasonPhrase); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void DeleteCarShowroom(int carshowroomId)
        {
            Task<CarShowroom> carShowroomTask = GetCarShowroom(carshowroomId);
            CarShowroom carShowroom = await carShowroomTask;
            if (carShowroom != null)
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync("api/CarShowrooms/" + carshowroomId))
                {
                    if (response.IsSuccessStatusCode) { }
                    else { throw new Exception(response.ReasonPhrase); }
                }
            }
        }

        public async Task<int> GetCarShowroomId(string name)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/CarShowrooms"))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<CarShowroom> carShowroomList = await response.Content.ReadAsAsync<List<CarShowroom>>();
                    return carShowroomList.Where(c => c.Name == name).Select(c=>c.CarShowroomId).FirstOrDefault();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

       
    }
}
