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
    public class CarShowroomContainerControler
    {
        public CarShowroomContainerControler()
        {

        }

        public async void AddCarShowroomContainer(CarShowroomContainer carShowroomContainer)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync("api/CarShowroomContainers", carShowroomContainer))
            {
                if (response.IsSuccessStatusCode) { }
                else { throw new Exception(response.ReasonPhrase); }
            }
        }
        public async Task<List<CarShowroomContainer>> GetCarShowroomContainer()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/CarShowroomContainers"))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<CarShowroomContainer> carShowroomContainerList = await response.Content.ReadAsAsync<List<CarShowroomContainer>>();
                    return carShowroomContainerList;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async void UpdateCarShowroomContainer(CarShowroomContainer carShowroomContainer)
        {
            try
            {
                Task<List<CarShowroomContainer>> newCarShowroomContainerListTask = GetCarShowroomContainer();
                List<CarShowroomContainer> newCarShowroomContainerList = await newCarShowroomContainerListTask;
                CarShowroomContainer newCarShowroomContainer = newCarShowroomContainerList.FirstOrDefault();

                if (newCarShowroomContainer == null)
                    throw new EntryPointNotFoundException("Vehiclee Not found in database");

                // doing nothing

                using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync("api/CarShowroomContainers/" + carShowroomContainer.CarShowroomContainerId, newCarShowroomContainer))
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

        public void DeleteCarShowroomContainer(int carShowroomContainerId)
        {
            // you can not delete the only CarShowroomContainer from database !!!
        }
    }
}
