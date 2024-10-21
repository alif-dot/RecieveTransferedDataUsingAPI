using IMSPOS_SDSIS.ContextFolder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace IMSPOS_SDSIS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SDSISController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SDSISController(AppDbContext context)
        {
            _context = context;
        }

        #region Sales

        [HttpPost]
        [Route("PutSales")]
        [AllowAnonymous]
        public async Task<IActionResult> PutSales([FromBody] Sale sale)
        {
            try
            {
                // Ensure SaleDetails is initialized
                if (sale.SaleDetails == null || !sale.SaleDetails.Any())
                {
                    return BadRequest("Sale must have at least one SaleDetail.");
                }

                // Check for duplicate SaleDetails by ItemId
                var duplicate = sale.SaleDetails.GroupBy(x => x.ItemId)
                                                .Where(x => x.Skip(1).Any());
                if (duplicate.Any())
                {
                    var duplicateItem = duplicate.FirstOrDefault().Key;
                    return BadRequest($"Item with ID {duplicateItem} is duplicate!");
                }

                // Add the sale to the database context
                _context.Sale.Add(sale);
                await _context.SaveChangesAsync();

                return Ok(new { Message = "Sale created successfully.", SaleId = sale.Id });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("GetSales")]
        public async Task<IActionResult> GetSales()
        {
            try
            {
                // Retrieve all sales including SaleDetails
                var sales = await _context.Sale
                    .Include(s => s.SaleDetails)
                    .ToListAsync();

                if (sales == null || !sales.Any())
                {
                    return NotFound("No sales found.");
                }

                return Ok(sales);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }
        #endregion Sales

        #region Purchase
        [HttpPost]
        [Route("PutPurchase")]
        [AllowAnonymous]
        public async Task<IActionResult> PutPurchase([FromBody] Purchase purchase)
        {
            try
            {
                // Ensure PurchaseDetails is initialized
                if (purchase.PurchaseDetails == null || !purchase.PurchaseDetails.Any())
                {
                    return BadRequest("Purchase must have at least one PurchaseDetails.");
                }

                // Check for duplicate PurchaseDetails by ItemId
                var duplicate = purchase.PurchaseDetails.GroupBy(x => x.ItemId)
                                                .Where(x => x.Skip(1).Any());
                if (duplicate.Any())
                {
                    var duplicateItem = duplicate.FirstOrDefault().Key;
                    return BadRequest($"Item with ID {duplicateItem} is duplicate!");
                }

                // Add the sale to the database context
                _context.Purchase.Add(purchase);
                await _context.SaveChangesAsync();

                return Ok(new { Message = "Purchase created successfully.", PurchaseId = purchase.Id });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }
        #endregion

        #region KOT
        [HttpPost]
        [Route("PutKOT")]
        [AllowAnonymous]
        public async Task<IActionResult> PutKOT([FromBody] KOTOrderMaster kotOrder)
        {
            try
            {
                if (kotOrder.KOTOrderDetails == null || !kotOrder.KOTOrderDetails.Any())
                {
                    return BadRequest("KOT must have at least one KOTOrderDetails.");
                }

                var duplicate = kotOrder.KOTOrderDetails.GroupBy(x => x.ItemId)
                                                .Where(x => x.Skip(1).Any());
                if (duplicate.Any())
                {
                    var duplicateItem = duplicate.FirstOrDefault().Key;
                    return BadRequest($"Item with ID {duplicateItem} is duplicate!");
                }

                // Add the sale to the database context
                _context.KOTOrderMaster.Add(kotOrder);
                await _context.SaveChangesAsync();

                return Ok(new { Message = "Purchase created successfully.", PurchaseId = kotOrder.Id });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }
        #endregion

        #region GoodsReceive
        [HttpPost]
        [Route("PutGoodsReceive")]
        [AllowAnonymous]
        public async Task<IActionResult> PutGoodsReceive([FromBody] GoodsReceive goodsReceive)
        {
            try
            {
                // Ensure PurchaseDetails is initialized
                if (goodsReceive.GoodsReceiveDetail == null || !goodsReceive.GoodsReceiveDetail.Any())
                {
                    return BadRequest("GoodsReceive must have at least one GoodsReceiveDetail.");
                }

                // Check for duplicate PurchaseDetails by ItemId
                var duplicate = goodsReceive.GoodsReceiveDetail.GroupBy(x => x.ItemId)
                                                .Where(x => x.Skip(1).Any());
                if (duplicate.Any())
                {
                    var duplicateItem = duplicate.FirstOrDefault().Key;
                    return BadRequest($"Item with ID {duplicateItem} is duplicate!");
                }

                // Add the sale to the database context
                _context.GoodsReceive.Add(goodsReceive);
                await _context.SaveChangesAsync();

                return Ok(new { Message = "GoodsReceive created successfully.", GoodsReceiveId = goodsReceive.Id });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }
        #endregion
    }
}
