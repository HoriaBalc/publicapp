namespace Application.DTOs
{
    public class PaceActivityDTOCreateUpdate
    {
      
            public Guid Id { get; private set; }

            public DateTime StartDate { get; set; }

            //seconds
            public int Duration { get; set; }

            public double Distance { get; set; }

            public int ElevationGain { get; set; }

            public int ElevationLoss { get; set; }

            public double Calories { get; set; }

            public bool InProgress { get; set; }

            public string SportName { get; set; }

            public string UserEmail { get; set; }

            public int Steps { get; set; }

        
    }
}
