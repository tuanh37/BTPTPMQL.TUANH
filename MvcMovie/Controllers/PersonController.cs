using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // DELETE: Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var person = await _context.Persons.FindAsync(id);

            // Kiểm tra nếu không tìm thấy người
            if (person == null)
            {
                return NotFound();
            }

            try
            {
                _context.Persons.Remove(person);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                // Đoạn này xử lý trường hợp ngoại lệ khi xóa người
                ModelState.AddModelError("", "There was an error deleting the person. Please try again later.");
                // Nếu cần, log lỗi chi tiết:
                // _logger.LogError(ex, "Error deleting person with ID {Id}", id);
            }

            return RedirectToAction(nameof(Index));
        }

        // Kiểm tra xem person có tồn tại hay không
        private bool PersonExists(string id)
        {
            return !string.IsNullOrEmpty(id) && _context.Persons.Any(e => e.PersonId == id);
        }

        // Cải tiến DebuggerDisplay, cung cấp thông tin chi tiết về person
        private string GetDebuggerDisplay()
        {
            // Trả về thông tin chi tiết về Person nếu có
            var person = _context.Persons.FirstOrDefault(p => p.PersonId == "specific_id"); // Sửa 'specific_id' theo yêu cầu
            return person != null ? $"Person: {person.PersonId}, Name: {person.FullName}" : "Person not found";
        }
    }
}
