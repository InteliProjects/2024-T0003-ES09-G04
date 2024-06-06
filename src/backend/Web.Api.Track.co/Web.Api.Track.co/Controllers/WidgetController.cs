using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Track.co.Data;
using Web.Api.Track.co.DTOs.NPS;
using Web.Api.Track.co.DTOs.Widget;
using Web.Api.Track.co.Service;

namespace Web.Api.Track.co.Controllers
{
    [ApiController]
    [Route("/widgets")]
    public class WidgetController : ControllerBase
    {
        private readonly ILogger<WidgetLogger> _logger;
        private readonly AppDbContext _context;
        private readonly WidgetService _widgetService;
        private readonly Meter _meter;

        private readonly Counter<int> _counter;

        private readonly ActivitySource _activity;

        public WidgetController(ILogger<WidgetLogger> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
            _widgetService = new WidgetService(logger, context);
            _meter = new Meter("OtPrGrYa.Example", "1.0.0");
            _counter = _meter.CreateCounter<int>("greetings.count", description: "Counts the number of greetings");
            _activity = new ActivitySource("WidgetController");
        }

        [HttpGet]
        public IActionResult Get()
        {
                try
            {
                using var activity = _activity.StartActivity("WidgetController.Get");

                _logger.LogInformation("Getting all widgets");

                _counter.Add(1);

                activity?.SetTag("Counter", "Added to counter");

                var widgets = _widgetService.GetWidgets();
                return Ok(widgets);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching widgets");
                return StatusCode(500,
                    new
                    {
                        error = true, message = "Internal server error occurred while fetching widgets"
                    });
            }
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                _logger.LogInformation($"Getting widget with ID {id} with corresponding NPS records");
                var widget = _widgetService.GetWidgetById(id);

                return Ok(widget);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("{id}/embedded")]
        public IActionResult GetEmbedded(int id)
        {
            try
            {
                _logger.LogInformation($"Getting embedded HTML for widget with ID {id}");
                var embeddedCode = _widgetService.GetEmbeddedHtml(id);

                return Ok(embeddedCode);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error occurred while fetching embedded HTML for widget with ID {id}");
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] WidgetCreateDto widgetDto)
        {
            try
            {
                _logger.LogInformation("Creating a new widget");

                var widget = await _widgetService.CreateWidget(widgetDto);
                
                return CreatedAtAction(nameof(Get), new { id = widget.Id }, widget);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new widget");
                return StatusCode(500,
                    new { error = true, message = "Internal server error occurred while creating a new widget" });
            }
        }

        [HttpPost("{widgetId}/nps")]
        public IActionResult PostNps(int widgetId, [FromBody] NPSCreateDto npsDto)
        {
            try {
                _logger.LogInformation($"Creating a new NPS record for widget with ID {widgetId}");

                var nps = _widgetService.CreateNps(widgetId, npsDto);

                return CreatedAtAction(nameof(GetNpsById), new { widgetId, npsId = nps.Id }, nps);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while creating a new NPS record for widget with ID {widgetId}");
                return StatusCode(500,
                    new
                    {
                        error = true,
                        message = $"Internal server error occurred while creating a new NPS record for widget with ID {widgetId}"
                    });
            }
        }

        [HttpGet("{widgetId}/nps/{npsId}")]
        public IActionResult GetNpsById(int widgetId, int npsId)
        {
            try
            {
                _logger.LogInformation($"Getting NPS record with ID {npsId} for widget with ID {widgetId}");

                var nps = _widgetService.GetNpsById(widgetId, npsId);

                return Ok(nps);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while fetching NPS record with ID {npsId} for widget with ID {widgetId}");
                return StatusCode(500,
                    new
                    {
                        error = true,
                        message = $"Internal server error occurred while fetching NPS record with ID {npsId} for widget with ID {widgetId}"
                    });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WidgetUpdateDto widgetUpdateDto)
        {
            try
            {
                _logger.LogInformation($"Updating widget with ID {id}");

                var widget = _widgetService.UpdateWidget(id, widgetUpdateDto);

                return Ok(widget);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while updating widget with ID {id}");
                return StatusCode(500,
                    new
                    {
                        error = true, message = $"Internal server error occurred while updating widget with ID {id}"
                    });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _logger.LogInformation($"Deleting widget with ID {id}");

                var widget = _widgetService.DeleteWidget(id);

                return Ok(widget);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while deleting widget with ID {id}");
                return StatusCode(500,
                    new
                    {
                        error = true, message = $"Internal server error occurred while deleting widget with ID {id}"
                    });
            }
        }
    }
}