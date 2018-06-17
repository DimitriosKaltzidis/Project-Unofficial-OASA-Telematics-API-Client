using OASA.Telematics.API.Models;
using System.Collections.Generic;

namespace OASA.Telematics.API.Client
{
    /// <summary>
    /// Επιστρέφει τα λεωφορεία που αναμένει σύντομα η στάση.
    /// Χρειαζόμαστε και μια παράμετρο που είναι το stopcode δηλαδή ο κώδικας μιας στάσης.
    /// Για να τον βρούμε μπορούμε να χρησιμοποιήσουμε την webGetStops.
    /// Π.Χ.: Στάση ΗΣΑΠ Ν.ΦΑΛΗΡΟΥ ( stopcode = 400075 )
    /// </summary>
    public class GetStopArrivalsCommand : PostCommand<List<StopArrival>>
    {
        public GetStopArrivalsCommand(string stopCode)
            : base($"getStopArrivals&p1={stopCode}")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει την τοποθεσία των λεωφορείων μιας συγκεκριμένης διαδρομής.
    /// Χρειαζόμαστε και μια παράμετρο που είναι το routecode δηλαδή ο κώδικας μιας διαδρομής.
    /// Π.Χ.: Διαδρομή ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ ( routecode = 2045 )
    /// </summary>
    public class GetBusLocationCommand : PostCommand<List<BusLocation>>
    {
        public GetBusLocationCommand(string routecode)
            : base($"getBusLocation&p1={routecode}")
        {
        }
    }

    /// <summary>
    /// Για να χρησιμοποιηθεί χρειαζόμαστε και την παράμετρο linecode που μπορούμε να την βρούμε αν φιλτράρουμε τον αριθμό του λεωφορείου που χρειαζόμαστε
    /// από τις δράσεις webGetLines και webGetLinesWithMLInfo
    /// Επιστρέφει το sdc_code, identifier για το ποιο πρόγραμμα/ωράριο ακολουθεί η γραμμή, το οποίο χρειάζεται για να κληθεί το getSchedLines function.
    /// Για παράδειγμα το Α1 (linecode = 962) που είναι η γραμμή ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ , έχει διαδρομές ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ και ΒΟΥΛΑ-ΠΕΙΡΑΙΑΣ.
    /// </summary>
    public class GetScheduleDaysCommand : PostCommand<List<ScheduleDaysMasterLine>>
    {
        public GetScheduleDaysCommand(string linecode)
            : base($"getScheduleDaysMasterline&p1={linecode}")
        {
        }
    }

    /// <summary>
    /// πιστρέφει τις διαδρομές/δρομολόγια(lines) που αντιστιχουν σε μια γραμμή(masterline).
    /// Για να χρησιμοποιηθεί χρειαζόμαστε και την παράμετρο mlcode που μπορούμε να την βρούμε
    /// αν φιλτράρουμε τον αριθμό του λεωφορείου που χρειαζόμαστε από τη δράση webGetLinesWithMLInfo
    /// </summary>
    public class GetLinesAndRoutesForMasterLineCommand : PostCommand<List<LinesAndRoutesForMasterLine>>
    {
        public GetLinesAndRoutesForMasterLineCommand(string masterLineCode)
            : base($"getLinesAndRoutesForMl&p1={masterLineCode}")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει τις διαδρομές σχετικά με την διαδρομή μιας γραμμής όμοια με την webGetRoutes.
    /// Για να χρησιμοποιηθεί χρειαζόμαστε και την παράμετρο linecode που μπορούμε να την βρούμε αν φιλτράρουμε τον αριθμό του λεωφορείου που χρειαζόμαστε από τις δράσεις webGetLines και webGetLinesWithMLInfo
    /// Για παράδειγμα το Α1(linecode = 962) που είναι η γραμμή ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ , έχει διαδρομές ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ και ΒΟΥΛΑ-ΠΕΙΡΑΙΑΣ.
    /// </summary>
    public class GetRoutesForLineCommand : PostCommand<List<RoutesForLine>>
    {
        public GetRoutesForLineCommand(string linecode)
            : base($"getRoutesForLine&p1={linecode}")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει το mlname. Δες getLinesAndRoutesForML. Για την χρήση αυτής της δράσης χρειάζεται το masterLineCode που το βρίσκουμε από την webGetLinesWithML
    /// </summary>
    public class GetMasterLineNameCommand : PostCommand<List<MasterLineName>>
    {
        public GetMasterLineNameCommand(string masterLineCode)
            : base($"getMLName&p1={masterLineCode}")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει το όνομα της γραμμής. Για να χρησιμοποιηθεί χρειαζόμαστε και την παράμετρο linecode που μπορούμε να την βρούμε
    /// αν φιλτράρουμε τον αριθμό του λεωφορείου που χρειαζόμαστε από τις δράσεις webGetLines και webGetLinesWithMLInfo
    /// Για παράδειγμα το Α1(linecode = 962) που είναι η γραμμή ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ , έχει διαδρομές ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ και ΒΟΥΛΑ-ΠΕΙΡΑΙΑΣ.
    /// </summary>
    public class GetLineNameCommand : PostCommand<List<LineName>>
    {
        public GetLineNameCommand(string linecode)
            : base($"getLineName&p1={linecode}")
        {
        }
    }

    /// <summary>
    /// Χρησιμοποιώντας το routecode το getRouteName επιστρέφει το όνομα της διαδρομής.
    /// </summary>
    public class GetRouteNameCommand : PostCommand<List<RouteName>>
    {
        public GetRouteNameCommand(string routeCode)
            : base($"getRouteName&p1={routeCode}")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει το όνομα της στάσης και τις συντεταγμένες της. Χρειαζόμαστε και μια παράμετρο που είναι το stopcode δηλαδή ο κώδικας μιας στάσης.
    /// Για να τον βρούμε μπορούμε να χρησιμοποιήσουμε την webGetStops.
    /// Στο παράδειγμα εμφανίζονται τα απότελέσματα του getStopArrivals της στάσης ΗΣΑΠ Ν.ΦΑΛΗΡΟΥ ( stopcode = 400075 )
    /// </summary>
    public class GetStopNameAndCoordinatesCommand : PostCommand<List<StopNameAndCoordinates>>
    {
        public GetStopNameAndCoordinatesCommand(string stopcode)
            : base($"getStopNameAndXY&p1={stopcode}")
        {
        }
    }

    /// <summary>
    /// Μας επιστρέφει τους χρόνους come και go που φαντάζομαι αντιστοιχούν στην αφετηρία και τέρμα.
    /// Χρειαζόμαστε masterLineCode, lineCode τα οποία μπορούμε να τα βρούμε από το webGetLinesWithML και sdcCode το οποίο μπορούμε να βρούμε από getScheduleDaysMasterline.
    /// π.χ.: http://telematics.oasa.gr/api/?act=getSchedLines&p1=128&p2=110&p3=966
    /// </summary>
    public class GetSchedLinesCommand : PostCommand<SchedLines>
    {
        public GetSchedLinesCommand(string masterLineCode, string sdcCode, string lineCode)
            : base($"getSchedLines&p1={masterLineCode}&p2={sdcCode}&p3={lineCode}")
        {
        }
    }

    /// <summary>
    /// Χρησιμοποιώντας το latitude και το longitude το getClosestStops επιστρέφει τις κοντινότερες στάσεις
    /// </summary>
    public class GetClosestStopsCommand : PostCommand<List<Stop>>
    {
        public GetClosestStopsCommand(string latitude, string longitude)
            : base($"getClosestStops&p1={latitude}&p2={longitude}")
        {
        }
    }
}
