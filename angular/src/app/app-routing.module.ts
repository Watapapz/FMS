import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { AppRouteGuard } from '@shared/auth/auth-route-guard';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { UsersComponent } from './users/users.component';
import { TenantsComponent } from './tenants/tenants.component';
import { RolesComponent } from 'app/roles/roles.component';
import { ChangePasswordComponent } from './users/change-password/change-password.component';
import { BankAccountComponent } from './banks/bank-account.component';
import { SchoolSystemComponent } from './school/school-system.component';
import { StudentComponent } from './school/school-student/student.component';
import { CreateStudentComponent } from './school/school-student/create-student/create-student.component';
import { ManageStudentComponent } from './school/school-student/manage-student/edit-student.component';
import { SubjectComponent } from './school/school-subject/subject.component';
import { CreateSubjectComponent } from './school/school-subject/create-subject/create-subject.component';
import { ManageSubjectComponent } from './school/school-subject/manage-subject/manage-subject.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                component: AppComponent,
                children: [
                    { path: 'home', component: HomeComponent,  canActivate: [AppRouteGuard] },
                    { path: 'users', component: UsersComponent, data: { permission: 'Pages.Users' }, canActivate: [AppRouteGuard] },
                    { path: 'roles', component: RolesComponent, data: { permission: 'Pages.Roles' }, canActivate: [AppRouteGuard] },
                    { path: 'tenants', component: TenantsComponent, data: { permission: 'Pages.Tenants' }, canActivate: [AppRouteGuard] },

                    { path: 'school', component: SchoolSystemComponent, canActivate:[AppRouteGuard]},
                    //students
                    { path: 'school/students', component: StudentComponent, canActivate:[AppRouteGuard]},
                    { path: 'school/student/create', component: CreateStudentComponent, canActivate:[AppRouteGuard]},
                    { path: 'school/student/manage/:id', component: ManageStudentComponent, canActivate:[AppRouteGuard]},
                    //subjects
                    { path: 'school/subject', component: SubjectComponent, canActivate:[AppRouteGuard]},
                    { path: 'school/subject/create', component: CreateSubjectComponent, canActivate:[AppRouteGuard]},
                    { path: 'school/subject/manage/:id', component: ManageSubjectComponent, canActivate:[AppRouteGuard]},

                    //{ path: 'bank-account', component: BankAccountComponent, canActivate: [AppRouteGuard] },
                    { path: 'about', component: AboutComponent },
                    { path: 'update-password', component: ChangePasswordComponent }
                ]
            }
        ])
    ],
    exports: [RouterModule]
})
export class AppRoutingModule { }
