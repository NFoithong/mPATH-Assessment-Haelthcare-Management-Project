# Healthcare Management Project - mPath Assessment
# Project Overview: 
Develop a healthcare-focused web application using .NET Core 8, Angular 18, and Entity Framework core 8 to manage patient recommendations. 
The system should allow users to log in, browse a list of patients, and view recommendations such as allergy checks and screenings.

# Project Goals:
* Authentication & Authorization:  Implement secure login functionality. Role-based access control (e.g., Admin, Healthcare Professional). 
* Patient Management:  Display a list of patients with pagination and filtering options. Search functionality by name or ID. 
* View detailed patient information.
* Display a list of recommendations (Allergy check, screenings, follow-ups) associated with a patient.  Allow users to mark recommendations as completed. 
* Security Considerations:  Implement OWASP security best practices (CSP, anti-CSRF, secure headers). Protect against SQL Injection, XSS, and authentication-related attacks. 

# Technical Requirements:
* Backend: .NET Core 8+ Web API. 
* Frontend: Angular 18 (using Angular Material components). 
* Database: SQL Server and Entity Framework. 
* API should follow RESTful principles.

# DESIGN SYSTEM
## Healthcare Web Application Design System
This design system outlines the core components and guidelines for building a scalable, secure, and user-friendly healthcare web application. It addresses both frontend and backend architecture, taking into account security, user experience, and responsive design.
## 1. User Interface Design (Frontend)
Framework: Angular 18 (with Angular Material)
## 2. Backend Architecture
Framework: .NET Core 8 Web API
## 3. Security Considerations
* Authentication & Authorization: JWT (JSON Web Tokens) for token-based authentication.
* Implement Role-based Access Control (RBAC)
* Admin: Full access to patient management and user roles.
* Healthcare Professional: Read access to patient data and recommendations.
* OWASP Security Best Practices
* Content Security Policy (CSP): Protect against XSS attacks.
* Anti-CSRF Tokens: Protect against Cross-Site Request Forgery attacks.
* Secure Headers: Add headers like Strict-Transport-Security and X-Content-Type-Options.
* Rate Limiting: Prevent brute force attacks by limiting login attempts.
## 4. Database Schema
The database should have the following entities:
## 5. Infrastructure and Deployment
Docker: Containerize the application for consistent environments across development, staging, and production.
## 6. Local Development Setup
``` Install Docker
Install Node.js (for Angular)
Install .NET Core SDK
SQL Server (or use Dockerized SQL Server)
```