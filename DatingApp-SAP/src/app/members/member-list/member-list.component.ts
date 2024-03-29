import { Component, OnInit } from '@angular/core';
import { IUser } from '../../_models/IUser';
import { UserService } from '../../_services/user.service';
import { AlertifyService } from '../../_services/Alertify.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

  users: IUser[];

  constructor(private userService: UserService, private alertify: AlertifyService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.users = data['users'];
    });
  }
/*
  loadUsers() {

    this.userService.getUsers().subscribe( (users: IUser[]) => {
      this.users = users;
    }, error => {
      this.alertify.error(error);
    } );
  }
*/
}
