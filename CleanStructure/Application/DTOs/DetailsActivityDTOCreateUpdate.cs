namespace Application.DTOs
{
    public class DetailsActivityDTOCreateUpdate
    {
            public DateTime StartDate { get; set; }

            //seconds
            public int Duration { get; set; }

            public double Distance { get; set; }

            public int ElevationGain { get; set; }

            public int ElevationLoss { get; set; }

            public double Calories { get; set; }

            public bool InProgress { get; set; }

            public Guid ActivityId { get; set; }


        
    }
}
