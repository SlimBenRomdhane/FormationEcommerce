namespace FormationEcommerce.Core.Utilities
{
    public static class StaticDetails
    {
        // Status of the order
        public const string Status_Pending = "Pending";

        public const string Status_Approved = "Approved";
        public const string Status_ReadyForPickup = "ReadyForPickup";
        public const string Status_Completed = "Completed";
        public const string Status_Refunded = "Refunded";
        public const string Status_Canceled = "Canceled";

        //User role constants
        public const string AdminRole = "Admin";

        public const string CustomerRole = "Customer";
    }
}