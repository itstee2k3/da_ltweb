//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using do_an_ltweb.Models;

//namespace do_an_ltweb.Admin.AdProduct
//{
//    [Authorize(Roles = "Admin")]
//    public class DeleteModel : RolePageModel
//    {
//        public DeleteModel(RoleManager<IdentityRole> roleManager, ApplicationDbContext applicationDbContext) : base(roleManager, applicationDbContext)
//        {

//        }
        

//        public IdentityRole role { get; set; }

//        public async Task<IActionResult> OnGet(string roleid)
//        {
//            if (roleid == null) return NotFound("Không tìm thấy role");

//            role = await _roleManager.FindByIdAsync(roleid);
//            if (role == null)
//            {
//                return NotFound("Không tìm thấy role");
//            } 
//            return Page();
//        }



//        public async Task<IActionResult> OnPostAsync(string roleid)
//        {
//            if (roleid == null) return NotFound("Không tìm thấy role");
//            role = await _roleManager.FindByIdAsync(roleid);
//            if (role == null) return NotFound("Không tìm thấy role");


//            var result = await _roleManager.DeleteAsync(role);

//            if (result.Succeeded)
//            {
//                StatusMessage = $"Bạn vừa xóa: {role.Name}";
//                return RedirectToPage("./Index");
//            }
//            else
//            {
//                result.Errors.ToList().ForEach(error => {
//                    ModelState.AddModelError(string.Empty, error.Description);
//                });
//            }
//            return Page();
//        }
//    }
//}
