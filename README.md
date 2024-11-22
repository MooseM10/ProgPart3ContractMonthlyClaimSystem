# **Contract Monthly Claim System**

The **Contract Monthly Claim System** is an ASP.NET Core MVC application designed to manage and streamline the process of submitting, verifying, and approving monthly claims. This system ensures that claims flow smoothly through various roles, including Lecturer, Program Coordinator, Academic Manager, and Human Resource views.

---

## **Features**

### **1. Lecturer View**
- **Submit Claims**:
  - Enter claim details, including hours worked and hourly rate.
  - Submit claims for verification by the Program Coordinator.

### **2. Program Coordinator View**
- **Verify Claims**:
  - View a list of claims submitted by lecturers.
  - Verify claims and forward them to the Academic Manager for approval.
  - Optionally reject claims or request more information.

### **3. Academic Manager View**
- **Review Pending Claims**:
  - View a list of claims that are pending approval from the Academic Manager.
  - Approve or reject claims based on validity.
  - Rejected claims are marked with a "Rejected by AC" status.

### **4. Human Resource View**
- **Final Review**:
  - View approved claims.
  - Finalize processing and mark claims as complete.

### **5. Real-Time Data Flow**
- Claims move through the pipeline from Lecturer → Program Coordinator → Academic Manager → Human Resource.
- Each claim's status updates dynamically as it moves through the process.

---

## **Project Structure**

### **Directories**
1. **Controllers**:
   - `LecturerController`: Handles lecturer-specific actions, including claim submission.
   - `ProgramCoordinatorController`: Manages the verification of claims submitted by lecturers.
   - `AcademicManagerController`: Handles the review and approval process of claims.
   - `HumanResourceController`: Manages the final approval and processing of claims.

2. **Views**:
   - Organized by role (`Lecturer`, `ProgramCoordinator`, `AcademicManager`, `HumanResource`).
   - Contains Razor views for submitting, verifying, and reviewing claims.

3. **Models**:
   - `Claim`: Represents the claim details, including ID, hours worked, hourly rate, and status.

4. **Data**:
   - Implements a temporary data storage mechanism for claim details.

---

## **How to Run the Application**

### **Requirements**
- .NET 6.0 SDK or later
- Visual Studio 2022 or any compatible IDE

### **Steps**
1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```bash
   cd ContractMonthlyClaimSystem
   ```
3. Build the project:
   ```bash
   dotnet build
   ```
4. Run the application:
   ```bash
   dotnet run
   ```
5. Open the application in your browser:
   ```plaintext
   https://localhost:<port>
   ```

---

## **Usage Workflow**

1. **Lecturer**:
   - Navigate to `/Lecturer`.
   - Fill in claim details (e.g., hours worked, hourly rate) and submit for verification.

2. **Program Coordinator**:
   - Navigate to `/ProgramCoordinator`.
   - View claims submitted by lecturers, verify details, and forward them to the Academic Manager.
   - Optionally reject claims or request additional information.

3. **Academic Manager**:
   - Navigate to `/AcademicManager`.
   - View claims that are pending approval.
   - Approve or reject claims.

4. **Human Resource**:
   - Navigate to `/HumanResource`.
   - View all approved claims and finalize processing.

---

## **Future Improvements**
- Add login and registration with role-based authentication.
- Integrate a database for persistent data storage.
- Improve the user interface for better accessibility and usability.

---

## **License**
This project is licensed under the MIT License.

---

This **README** now includes the **Program Coordinator** role, as per your request. Let me know if you need further modifications!
