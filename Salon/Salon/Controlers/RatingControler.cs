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
    public class RatingControler
    {
        public RatingControler() { }

        public async void AddRating(Rating rating)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync("api/Ratings", rating))
            {
                if (response.IsSuccessStatusCode) { }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<Rating> GetRating(int RatingId)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/Ratings/" + RatingId))
            {
                if (response.IsSuccessStatusCode)
                {
                    Rating rating = await response.Content.ReadAsAsync<Rating>();
                    return rating;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<List<Rating>> GetRatings(int salonId)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/Ratings"))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Rating> ratings = await response.Content.ReadAsAsync<List<Rating>>();
                    return ratings.Where(r=>r.SalonId == salonId).ToList();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async void UpdateRating(int ratingId,Rating rating)
        {
            try
            {
                Task<Rating> newRatingTask = GetRating(ratingId);
                Rating newRating = await newRatingTask;

                if (newRating == null)
                    throw new EntryPointNotFoundException("Vehiclee Not found in database");

                newRating.value = rating.value;
                newRating.Description = rating.Description;
                newRating.date = DateTime.Now;
                using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync("api/Ratings/" + ratingId, newRating))
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

        public async void DeleteRating(int RatingId)
        {
            Task<Rating> ratingTask = GetRating(RatingId);
            Rating rating = await ratingTask;
            if (rating != null)
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync("api/Ratings/" + RatingId))
                {
                    if (response.IsSuccessStatusCode) { }
                    else { throw new Exception(response.ReasonPhrase); }
                }
            }
        }

        public async Task<Rating> GetRatingBySalonId(int salonId)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/Ratings"))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Rating> ratings = await response.Content.ReadAsAsync<List<Rating>>();
                    return ratings.Where(r => r.SalonId == salonId).FirstOrDefault();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
