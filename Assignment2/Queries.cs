namespace Assignment2;

public class Queries
{
    
   public static IEnumerable<string> findRowlings(WizardCollection wizards)
   {
      return wizards.Where(w=> w.Creator == "J.K. Rowling").Select(w => w.Name);
   }

   public static IEnumerable<string> findRowlingAgain(WizardCollection wizards)
   {
       var rowlings = from w in wizards
                  where w.Creator == "J.K. Rowling"
                  select w.Name;

      return rowlings;
   }

   public static int findSithYear(WizardCollection wizards)
   {
      return (int) wizards
      .Where(w => w.Name.StartsWith("Darth"))
      .OrderBy(w => w.Year)
      .First().Year!;
   }

   public static int findSithYearAgain(WizardCollection wizards)
   {
         return (int) (from w in wizards
               where w.Name.StartsWith("Darth")
               orderby w.Year
               select w.Year).First()!;
   }

   public static IEnumerable<(string, int?)> findHarryPotterCharater(WizardCollection wizards)
   {
      return wizards
            .Where(w => w.Medium.StartsWith("Harry"))
            .Select(w => (w.Name, w.Year));

   }

   public static IEnumerable<(string, int?)> findHarryPotterCharaterAgain(WizardCollection wizards)
   {
      return from w in wizards
            where w.Medium.StartsWith("Harry")
            select (w.Name, w.Year);

   }

   public static IEnumerable<string> findWizardNames(WizardCollection wizards)
   {
      return wizards
            .OrderByDescending(w => w.Creator)
            .ThenBy(w => w.Name)
            .Select(w => w.Name);
   }

   public static IEnumerable<string> findWizardNamesAgain(WizardCollection wizards)
   {
      return from w in wizards
            orderby w.Creator descending, w.Name
            select w.Name;
   }
}
