<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Admin Dashboard</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pcoded-content">
                        <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <%--<h5 class="m-b-10">Dashboard</h5>--%>
                                            <h3>Dashboard</h3>
                                            <h4>Welcome to Karachi Metropolitan Corporation</h4>
                                            <%--<p class="m-b-0">Welcome to Karachi Metropolitan Corporation</p>--%>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="#!">Dashboard</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Page-header end -->
                        <div class="pcoded-inner-content">
                            <!-- Main-body start -->
                            <div class="main-body">
                                <div class="page-wrapper">
                                    <!-- Page-body start -->
                                    <div class="page-body">
                                        <div class="row">
                                            <!-- task, page, download counter  start -->
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-purple" id="AdminAllConsumer" runat="server">Not Connected to server</h4>
                                                                <h6 class="text-muted m-b-0">All Consumers</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-bar-chart f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-purple">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">New Consumers</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>

                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-green" id="AdminMuctEmployeebill" runat="server">0</h4>
                                                                <h6 class="text-muted m-b-0">Daily Bill Issued</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-file-text-o f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-green">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">MUCT Employee Bill</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-red" id="AdminSearchingSheetbill" runat="server">0</h4>
                                                                <h6 class="text-muted m-b-0">Daily Bill Issued</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-calendar-check-o f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-red">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Searching Sheet</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-blue" id="AdminStubPosted" runat="server">0</h4>
                                                                <h6 class="text-muted m-b-0">Daily Posted</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-hand-o-down f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-blue">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Stub Posted</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- task, page, download counter  end -->

                                            <!--  sale analytics start -->
                                            <div class="col-xl-8 col-md-12">
                                                <div class="row">
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">KMC Head Office</h6>
                                                                <h4 id="AdminHeadofficeDaily" runat="server" class="m-t-15 m-b-15"><i class="fa fa-arrow-down m-r-15 text-c-red"></i>0</h4>
                                                                <p class="m-b-0">Total Daily Bill Issued</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">KMC Camp Office</h6>
                                                                <h4 id="AdminCampOffice" runat="server" class="m-t-15 m-b-15"><i class="fa fa-arrow-up m-r-15 text-c-green"></i>0</h4>
                                                                <p class="m-b-0">Total Daily Bill Issued</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">15% Part Payment</h6>
                                                                <h4 id="Admin15percentbill" runat="server" class="m-t-15 m-b-15"><i class="fa fa-arrow-up m-r-15 text-c-green"></i>0</h4>
                                                                <p class="m-b-0">Daily Bill Issued</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">Duplicate Bill</h6>
                                                                <h4 id="Adminduplicatebill" runat="server" class="m-t-15 m-b-15"><i class="fa fa-arrow-down m-r-15 text-c-red"></i>0</h4>
                                                                <p class="m-b-0">Daily Bill Issued</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                     <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">Complete Bill</h6>
                                                                <h4 id="AdminCompletebill" runat="server" class="m-t-15 m-b-15"><i class="fa fa-arrow-up m-r-15 text-c-green"></i>5963</h4>
                                                                <p class="m-b-0">Daily Bill Issued</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">Rebate Bill</h6>
                                                                <h4 id="AdminRebatebill" runat="server" class="m-t-15 m-b-15"><i class="fa fa-arrow-down m-r-15 text-c-red"></i>0</h4>
                                                                <p class="m-b-0">Daily Bill Issued</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="card table-card">
                                                    <div class="card-header">
                                                        <h5>KMC Departments New Consumers List (Daily)</h5>
                                                        
                                                    </div>
                                                    <div class="card-block">
                                                        <div class="table-responsive">
                                                            <table class="table table-hover" id="Admintablenewkmcdeptconsumer" runat="server">
                                                                <thead>
                                                                    <tr>
                                                                       
                                                                            <th>Department</th>
                                                                        <th>New ID</th>
                                                                        <th>Created By</th>
                                                                        <th>Districts</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                                <div class="d-inline-block">
                                                                                    <h6>Katchi Abadi Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td id="tbKAConsumer" runat="server">0</td>
                                                                        <td id="tbKACreatedby" runat="server">Null</td>
                                                                        <td id="tbKAZone" runat="server">Null</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                               
                                                                                <div class="d-inline-block">
                                                                                    <h6>Land Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td id="tbLandConsumer" runat="server">0</td>
                                                                        <td id="tbLandCreatedby" runat="server">Null</td>
                                                                        <td id="tbLandZone" runat="server">Null</td>
                                                                    </tr>

                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                               
                                                                                <div class="d-inline-block">
                                                                                    <h6>PD Orangi Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td id="tbPDOConsumer" runat="server">0</td>
                                                                        <td id="tbPDOCreatedby" runat="server">Null</td>
                                                                        <td id="tbPDOZone" runat="server">Null</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                               
                                                                                <div class="d-inline-block">
                                                                                    <h6>Charge Parking Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td id="tbParkingConsumer" runat="server">0</td>
                                                                        <td id="tbParkingCreatedby" runat="server">Null</td>
                                                                        <td id="tbParkingZone" runat="server">Null</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                               
                                                                                <div class="d-inline-block">
                                                                                    <h6>Estate Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td id="tbEstateConsumer" runat="server">0</td>
                                                                        <td id="tbEstateCreatedby" runat="server">Null</td>
                                                                        <td id="tbEstateZone" runat="server">Null</td>
                                                                    </tr>
                                                                  
                                                                </tbody>
                                                            </table>
                                                            <div class="text-right m-r-20">
                                                                <a href="#!" class=" b-b-primary text-primary">View all Vendors</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>

                                            <div class="col-xl-4 col-md-12">
                                                   <div class="card quater-card">
                                                    <div class="card-block">
                                                        <h6 class="text-muted m-b-15">Bank's Posted Voucher (Bank Wise)</h6>
                                                        <h4 id="AdminTotalpostingVoucher" runat="server">3,9452 Rs</h4>
                                                        <p class="text-muted">Total Amount of Posted Voucher</p>
                                                        <h5>Habib Bank Limited</h5>
                                                        <p class="text-muted">Posted<span class="f-right" id="Adminhblposteddaily" runat="server">0</span></p>
                                                        <div class="progress">
                                                            <div class="progress-bar bg-c-blue"  id="Adminhblposteddailypercent" runat="server"></div>
                                                        </div>
                                                        <h5 class="m-t-15">National Bank of Pakistan</h5>
                                                        <p class="text-muted">Posted<span class="f-right" id="Adminnbpposteddaily" runat="server">0</span></p>
                                                        <div class="progress">
                                                            <div class="progress-bar bg-c-green" style="width: 0" id="Adminnbpposteddailypercent" runat="server"></div>
                                                        </div>
                                                        <h5 class="m-t-15">Sindh Bank of Pakistan</h5>
                                                        <p class="text-muted">Posted<span class="f-right" id="Adminsbpposteddaily" runat="server">0</span></p>
                                                        <div class="progress">
                                                            <div class="progress-bar bg-c-red" style="width: 0" id="Adminsbpposteddailypercent" runat="server"></div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="card quater-card">
                                                    <div class="card-block">
                                                         <div class="card-header">
                                                        <h5>Bank's Posted Voucher (Bank Wise)</h5>
                                                    </div>
                                                    <div class="card-block">
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-2.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>Wahaj</h6>
                                                                <p class="text-muted m-b-0" id="Adminpostingdailyemp1" runat="server">0</p>
                                                            </div>
                                                        </div>
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-1.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>Wajahat</h6>
                                                                <p class="text-muted m-b-0" id="Adminpostingdailyemp2" runat="server">0</p>
                                                            </div>
                                                        </div>
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-3.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>Ali</h6>
                                                                <p class="text-muted m-b-0" id="Adminpostingdailyemp3" runat="server">0</p>
                                                            </div>
                                                        </div>
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-4.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>Zain</h6>
                                                                <p class="text-muted m-b-0" id="Adminpostingdailyemp4" runat="server">0</p>
                                                            </div>
                                                        </div>
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-4.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>Raafay</h6>
                                                                <p class="text-muted m-b-0" id="Adminpostingdailyemp5" runat="server">0</p>
                                                            </div>
                                                        </div>
                                                        <div class="text-center">
                                                            <a href="#!" class="b-b-primary text-primary">View all</a>
                                                        </div>
                                                    </div>
                                                    </div>

                                                </div>

                                               
                                            </div>

                                            

                                                <!-- income start -->
                                            <div class="col-xl-4 col-md-6">
                                                <div class="card">
                                                    <div class="card-header">
                                                        <h5>KMC Head Office</h5>
                                                    </div>
                                                    <div class="card-block">
                                                        <p class="text-c-green f-w-500"><i class="fa fa-caret-up m-r-15"></i> Daily Bill Report</p>
                                                        <div class="row">
                                                            <div class="col-4 b-r-default">
                                                                <p class="text-muted m-b-5">Complete</p>
                                                                <h5 id="AdminHOCompletebill" runat="server">Null</h5>
                                                            </div>
                                                            <div class="col-4 b-r-default">
                                                                <p class="text-muted m-b-5">Rebate</p>
                                                                <h5 id="AdminHORebatebill" runat="server">Null</h5>
                                                            </div>
                                                            <div class="col-4">
                                                                <p class="text-muted m-b-5">Duplicate</p>
                                                                <h5 id="AdminHODuplicatebill" runat="server">Null</h5>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <canvas id="tot-lead" height="150"></canvas>
                                                </div>
                                            </div>
                                            <div class="col-xl-4 col-md-6">
                                                <div class="card">
                                                    <div class="card-header">
                                                        <h5>KMC Camp Office</h5>
                                                    </div>
                                                    <div class="card-block">
                                                        <p class="text-c-red f-w-500"><i class="fa fa-caret-down m-r-15"></i> Daily Bill Report</p>
                                                        <div class="row">
                                                            <div class="col-4 b-r-default">
                                                                <p class="text-muted m-b-5">Complete</p>
                                                                <h5 id="AdminCOCompletebill" runat="server">Null</h5>
                                                            </div>
                                                            <div class="col-4 b-r-default">
                                                                <p class="text-muted m-b-5">Rebate</p>
                                                                <h5 id="AdminCORebatebill" runat="server">Null</h5>
                                                            </div>
                                                            <div class="col-4">
                                                                <p class="text-muted m-b-5">Duplicate</p>
                                                                <h5 id="AdminCODuplicatebill" runat="server">Null</h5>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <canvas id="tot-vendor" height="150"></canvas>
                                                </div>
                                            </div>
                                            <!-- income end -->
                                            <div class="col-xl-4 col-md-6">
                                                <div class="card trafic-card">
                                                    <div class="card-header">
                                                        <h5>Impact & Personal Information Area</h5>
                                                    </div>
                                                    <div class="card-block">
                                                        <p class="m-b-10">Modification Case <span class="f-right"><i class="fa fa-caret-up m-r-10"></i>25%</span></p>
                                                        <div class="progress blue">
                                                            <div class="progress-bar bg-c-blue" style="width:75%"></div>
                                                        </div>
                                                        <p class="m-b-10 m-t-30">Change of Name <span class="f-right"><i class="fa fa-caret-down m-r-10"></i>58</span></p>
                                                        <div class="progress green">
                                                            <div class="progress-bar bg-c-green" style="width:50%"></div>
                                                        </div>
                                                        <p class="m-b-10 m-t-30">Change of Address <span class="f-right"><i class="fa fa-caret-up m-r-10"></i>20%</span></p>
                                                        <div class="progress red">
                                                            <div class="progress-bar bg-c-red" style="width:20%"></div>
                                                        </div>
                                                        <p class="m-b-10 m-t-30">Employee Rebate <span class="f-right"><i class="fa fa-caret-down m-r-10"></i>580</span></p>
                                                        <div class="progress yellow">
                                                            <div class="progress-bar bg-c-yellow" style="width:40%"></div>
                                                        </div>
                                                       
                                                    </div>
                                                </div>
                                            </div>
                                            <!--  sale analytics end -->
                                            <div class="card table-card">
                                                    <div class="card-header">
                                                        <h5>KMC Departments Suspended Consumers List (Daily)</h5>
                                                        
                                                    </div>
                                                    <div class="card-block">
                                                        <div class="table-responsive">
                                                            <table class="table table-hover">
                                                                <thead>
                                                                    <tr>
                                                                        <th>Department</th>
                                                                        <th>Same IDs</th>
                                                                        <th>Created By</th>
                                                                        <th>Districts</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                                <div class="d-inline-block">
                                                                                    <h6>Katchi Abadi Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td id="tbKAConsumerSame" runat="server">Null</td>
                                                                        <td id="tbKACreatedbySame" runat="server">Null</td>
                                                                        <td id="tbKAZoneSame" runat="server">Null</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                               
                                                                                <div class="d-inline-block">
                                                                                    <h6>Land Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td id="tbLandConsumerSame" runat="server">Null</td>
                                                                        <td id="tbLandCreatedbySame" runat="server">Null</td>
                                                                        <td id="tbLandZoneSame" runat="server">Null</td>
                                                                    </tr>

                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                               
                                                                                <div class="d-inline-block">
                                                                                    <h6>PD Orangi Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td id="tbPDOConsumerSame" runat="server">Null</td>
                                                                        <td id="tbPDOCreatedbySame" runat="server">Null</td>
                                                                        <td id="tbPDOZoneSame" runat="server">Null</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                               
                                                                                <div class="d-inline-block">
                                                                                    <h6>Charge Parking Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td id="tbParkingConsumerSame" runat="server">Null</td>
                                                                        <td id="tbParkingCreatedbySame" runat="server">Null</td>
                                                                        <td id="tbParkingZoneSame" runat="server">Null</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="d-inline-block align-middle">
                                                                               
                                                                                <div class="d-inline-block">
                                                                                    <h6>Estate Department</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                         <td id="tbEstateConsumerSame" runat="server">Null</td>
                                                                        <td id="tbEstateCreatedbySame" runat="server">Null</td>
                                                                        <td id="tbEstateZoneSame" runat="server">Null</td>
                                                                    </tr>
                                                                  
                                                                </tbody>
                                                            </table>
                                                            <div class="text-right m-r-20">
                                                                <a href="#!" class=" b-b-primary text-primary">View all Vendors</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                          
                                            </div>
                                        </div>
                                             
                                    </div>
                                    <!-- Page-body end -->
                                </div>
                                <div id="styleSelector"> </div>
                            </div>
                        </div>
</asp:Content>

