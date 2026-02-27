using Assignment_1.Modals;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using Assignment_1.DTO;

namespace Assignment_1.Services
{
    public class EmployeeServices
    {
        private readonly HttpClient _http;

        public EmployeeServices(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Employee>> GetEmployee()
        {
            return await _http.GetFromJsonAsync<List<Employee>>($"api/Employee");
        }

        public async Task<bool> isEmployee(string employeeId)
        {
            return await _http.GetFromJsonAsync<bool>($"api/Employee/exist/{employeeId}");
        }
       
        public async System.Threading.Tasks.Task UpdatePassword(string id,string password)
        {
          await _http.PutAsync($"api/Employee/update-password?employee_id={id}&newPassword={password}", null);
        }

        public async System.Threading.Tasks.Task addUer(Employee employee)
        {
            await _http.PostAsJsonAsync($"api/Employee/add-user", employee);
        }

        public async Task<Employee> LoginValidation(LoginDto login)
        {
            var response = await _http.PostAsJsonAsync($"api/Employee/login",login);
            if (!response.IsSuccessStatusCode)
            {
                return null;  
            }
            if (response.Content.Headers.ContentLength == 0)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<Employee>();
        }
    }
}
