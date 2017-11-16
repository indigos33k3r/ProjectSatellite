import React from 'react';
import PropTypes from 'prop-types';
import TabHeader from '../components/TabHeader';
import NotificationList from '../components/NotificationList';
import MessageEdit from '../components/MessageEdit';

export class NotificationPage extends React.Component {
  render() {
    const SubTabs = ['Current', 'Past', 'New'];
    const Notifications = {
      Current: [
        {
          Id: 1,
          Title: "AccountRight 2017.2 Launched!",
          Body: "The dev team is pleased to announce that AccountRight 2017.2 is now launched.",
          Links: [
            {
              Name: "More Info",
              Uri: "https://www.myob.com/au/support/download-accountright"
            }
          ],
          Groups: [""],
          CreatedBy: "Dominic.Shelton",
          CreatedDate: "2017-11-10",
          StartDate: "2017-11-12",
          EndDate: "2017-11-30"
        }
      ],
      Past: [
        {
          Id: 1,
          Title: "AccountRight 2017.1 Launched!",
          Body: "The Product team is pleased to announce that AccountRight 2017.1 has now been launched and is available for clients.",
          Links: [
            {
              Name: "More Info",
              Uri: "https://www.myob.com/au/support/download-accountright"
            }
          ],
          Groups: [""],
          CreatedBy: "Dean.Novelly",
          CreatedDate: "2017-06-10",
          StartDate: "2017-06-02",
          EndDate: "2017-06-16"
        }
      ]
    };

    return (
      <div>
        <TabHeader Prefix="Notifications" Headers={SubTabs} />
        {this.props.match.params.View === 'New'
          ? <MessageEdit />
          : <NotificationList Notifications={Notifications[this.props.match.params.View]} />
        }
      </div>
    );
  }
}

NotificationPage.propTypes = {
  match: PropTypes.objectOf(PropTypes.string).isRequired
};

export default NotificationPage;
