using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Assignment_1.Services
{
    public class EmployeeTaskService
    {
        private readonly HttpClient _http;

        public EmployeeTaskService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Assignment_1.Modals.Task>> getTasks(string employeeId)
        {
            return await _http.GetFromJsonAsync<List<Assignment_1.Modals.Task>>(
        $"api/EmployeeTask?employeeId={employeeId}");
        }
        public async Task<Assignment_1.Modals.Task?> getTAskById(int taskId)
        {
          return  await _http.GetFromJsonAsync<Assignment_1.Modals.Task>($"api/EmployeeTask/{taskId}");
        }
        public async Task addTasks(Assignment_1.Modals.Task task)
        {
             await _http.PostAsJsonAsync($"api/EmployeeTask",task);
        }

        public async Task editTask(int id,Assignment_1.Modals.Task task)
            
        {
            try

            {
              
                var response = await _http.PutAsJsonAsync($"api/EmployeeTask/{id}", task);

                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Status Code: {response.StatusCode}\n\nError:\n{responseContent}"
                    );
                }
                else
                {
                    MessageBox.Show("Task updated successfully.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception:\n" + ex.ToString());
            }

        }
        //public async Task<List<Assignment_1.Modals.Task>?> ToggleStatus(string employeeId, string status)
        //{
        //    var response = await _http.GetAsync(
        //     $"api/EmployeeTask/toggle-status?employeeId={employeeId}&status={status}");

        //    if (!response.IsSuccessStatusCode)
        //        return null;

        //    return await response.Content
        //        .ReadFromJsonAsync<List<Assignment_1.Modals.Task>>();
        //}
        public async Task deleteTask(int id)
        {
            await _http.DeleteAsync($"api/EmployeeTask/{id}");
        }

    }
}
