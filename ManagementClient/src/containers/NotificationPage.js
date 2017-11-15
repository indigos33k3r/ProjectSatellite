import React from 'react';
import PropTypes from 'prop-types';
import TabHeader from '../components/TabHeader';
import NotificationList from '../components/NotificationList';

export class NotificationPage extends React.Component {
  render() {
    const SubTabs = ['Current', 'Past', 'New'];
    return (
      <div>
        <TabHeader Prefix="Notifications" Headers={SubTabs} />
        <NotificationList View={this.props.match.params.View} />
      </div>
    );
  }
}

NotificationPage.propTypes = {
  match: PropTypes.objectOf(PropTypes.string).isRequired
};

export default NotificationPage;
