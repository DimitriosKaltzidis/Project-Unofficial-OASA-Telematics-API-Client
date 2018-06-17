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

    /// <summary>
    /// Επιστρέφει τα στοιχεία σχετικά με όλες τις γραμμές των λεωφορείων.
    /// Line_Code: Το Line_Code είναι ο μοναδικός αριθμός που ορίζει το software της τηλεματικής στην κάθε γραμμή. Βάσει αυτού του αριθμού γίνονται όλοι συσχετισμοί στην βάση δεδομένων του ΟΑΣΑ. Επίσης φαίνεται να είναι URI.
    /// line_ID: Unicode formatted string το οποίο είναι ο αριθμός της γραμμής
    /// Line_Descr: Unicode formatted string, με τον τίτλο της γραμμής, ‘ΠΛΑΤΕΙΑ ΚΑΝΙΓΓΟΣ - ΓΚΥΖH(ΚΥΚΛΙΚΗ)’
    /// Line_Descr_Eng: Ίδιο με το line_descr αλλά ascii formatted
    /// </summary>
    public class GetLinesCommand : PostCommand<List<Line>>
    {
        public GetLinesCommand()
            : base($"webGetLines")
        {
        }
    }

    /// <summary>
    /// Είναι όμοιο με το webGetLines μόνο που στέλνει δύο παραπάνω στοιχεία το ml_code και το sdc_code.
    /// ml_code: Identifier που έχει να κάνει με την περιοχή έναρξης. (Help needed) Πιθανότατα το ml αντιστοιχεί στο MasterLine.
    /// sdc_code: Identifier για το ωράριο που ακολουθεί η γραμμή, δες getSchedLines και getScheduleDaysMasterLine
    /// Line_Code: Το Line_Code είναι ο μοναδικός αριθμός που ορίζει το software της τηλεματικής στην κάθε γραμμή.Βάσει αυτού του αριθμού γίνονται όλοι συσχετισμοί στην βάση δεδομένων του ΟΑΣΑ.Επίσης φαίνεται να είναι URI.
    /// line_ID: Unicode formatted string το οποίο είναι ο αριθμός της γραμμής
    /// line_descr: Unicode formatted string, με τον τίτλο της γραμμής, ‘ΠΛΑΤΕΙΑ ΚΑΝΙΓΓΟΣ - ΓΚΥΖH(ΚΥΚΛΙΚΗ)’
    /// line_descr_eng: Ίδιο με το line_descr αλλά ascii formatted
    /// </summary>
    public class GetLinesWithMLInfoCommand : PostCommand<List<LineWithMasterLineInfo>>
    {
        public GetLinesWithMLInfoCommand()
            : base($"webGetLinesWithMLInfo")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει τις διαδρομές σχετικά με την διαδρομή μιας γραμμής. Για να χρησιμοποιηθεί χρειαζόμαστε και την παράμετρο linecode που μπορούμε να την βρούμε αν φιλτράρουμε τον αριθμό του λεωφορείου που χρειαζόμαστε από τις δράσεις webGetLines και webGetLinesWithMLInfo
    /// Για παράδειγμα το Α1(linecode = 962) που είναι η γραμμή ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ , έχει διαδρομές ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ και ΒΟΥΛΑ-ΠΕΙΡΑΙΑΣ.
    /// </summary>
    public class GetRoutesCommand : PostCommand<List<Route>>
    {
        public GetRoutesCommand(string lineCode)
            : base($"webGetRoutes&p1={lineCode}")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει τις στάσεις μιας διαδρομής.
    /// Χρειαζόμαστε και μια παράμετρο που είναι το routecode δηλαδή ο κώδικας μιας διαδρομής.
    /// Στο παράδειγμα εμφανίζεται η πρώτη στάση της διαδρομής ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ ( routecode = 2045 )
    /// </summary>
    public class GetStopsCommand : PostCommand<List<FullStop>>
    {
        public GetStopsCommand(string routecode)
            : base($"webGetStops&p1={routecode}")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει τις λεπτομέρειες της διαδρομής δηλαδή την τοποθεσία των στάσεων και την σειρά με την οποία τις ‘επισκέπτεται’ το λεωφορείο.
    /// Χρησιμοποιείται κυρίως για απεικόνηση στο google maps Χρειαζόμαστε και μια παράμετρο που είναι το routecode δηλαδή ο κώδικας μιας διαδρομής.
    /// Στο παράδειγμα εμφανίζονται τα απότελέσματα του webRouteDetails της διαδρομής ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ ( routecode = 2045 )
    /// </summary>
    public class GetRouteDetailsCommand : PostCommand<List<RouteDetails>>
    {
        public GetRouteDetailsCommand(string routeCode)
            : base($"webRouteDetails&p1={routeCode}")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει πληροφορίες σχετικά με μια στάση. Χρειαζόμαστε και μια παράμετρο που είναι το stopcode δηλαδή ο κώδικας μιας στάσης.
    /// Για να τον βρούμε μπορούμε να χρησιμοποιήσουμε την webGetStops.
    /// Στο παράδειγμα εμφανίζονται τα απότελέσματα του webRoutesForStop της στάσης ΗΣΑΠ Ν.ΦΑΛΗΡΟΥ ( stopcode = 400075 )
    /// </summary>
    public class GetRoutesForStopCommand : PostCommand<List<Route>>
    {
        public GetRoutesForStopCommand(string stopCode)
            : base($"webRoutesForStop&p1={stopCode}")
        {
        }
    }

    /// <summary>
    /// Επιστρέφει τις λεπτομέρειες της διαδρομής και συγκεκριμένα τις στάσεις,
    /// την σειρά με την οποία εμφανίζονται και την τοποθεσία τους.
    /// Χρειαζόμαστε και μια παράμετρο που είναι το routecode δηλαδή ο κώδικας μιας διαδρομής.
    /// Στο παράδειγμα εμφανίζονται τα απότελέσματα του webGetRoutesDetailsAndStops της διαδρομής ΠΕΙΡΑΙΑΣ-ΒΟΥΛΑ ( routecode =2045)
    /// </summary>
    public class GetRoutesDetailsAndStopsCommand : PostCommand<RouteDetailsAndStops>
    {
        public GetRoutesDetailsAndStopsCommand(string routeCode)
            : base($"webGetRoutesDetailsAndStops&p1={routeCode}")
        {
        }
    }


    public class GetLangsCommand : PostCommand<List<Localizations>>
    {
        public GetLangsCommand()
            : base($"webGetLangs")
        {
        }
    }

    public class GetMasterLinesCommand : PostCommand<List<MasterLine>>
    {
        public GetMasterLinesCommand()
            : base($"webGetMasterLines")
        {
        }
    }
}
